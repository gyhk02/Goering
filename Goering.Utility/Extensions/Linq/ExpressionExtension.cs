using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Goering.Extensions
{
    /*
     使用：
            using (var db = new MyDbContext())
            {
                var predicate = PredicateBuilder.True<Student>();
                predicate=predicate.And(s => s.ID > 1200);
                predicate=predicate.Or(s => s.ID < 1000);
                var result = db.Students.Where(predicate).ToList();
            }
     */
    public class ParameterRebinder : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, ParameterExpression> map;

        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
        {
            this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }

        public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp)
        {
            return new ParameterRebinder(map).Visit(exp);
        }

        protected override Expression VisitParameter(ParameterExpression p)
        {
            ParameterExpression replacement;
            if (map.TryGetValue(p, out replacement))
            {
                p = replacement;
            }
            return base.VisitParameter(p);
        }
    }

    public static class ExpressionExtension
    {
        /// <summary>
        /// 创建一个对应的对象的表达式对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Expression<Func<T, bool>> CreateExpression<T>()
        {
            Expression<Func<T, bool>> exp = null;
            return exp;
        }

        private static Expression<T> Compose<T>(this Expression<T> first, Expression<T> second, Func<Expression, Expression, Expression> merge)
        {
            // build parameter map (from parameters of second to parameters of first)  
            var map = first.Parameters.Select((f, i) => new { f, s = second.Parameters[i] }).ToDictionary(p => p.s, p => p.f);

            // replace parameters in the second lambda expression with parameters from the first  
            var secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);

            // apply composition of lambda expression bodies to parameters from the first expression   
            return Expression.Lambda<T>(merge(first.Body, secondBody), first.Parameters);
        }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            if (first == null)
            {
                return second;
            }
            else
            {
                return first.Compose(second, Expression.And);
            }

        }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.Or);
        }

    }

    public class WhereBuilder : ExpressionVisitor
    {

        #region Protected Properties
        /// <summary>
        /// Gets a <c>System.String</c> value which represents the AND operation in the WHERE clause.
        /// </summary>
        protected virtual string And
        {
            get { return "AND"; }
        }
        /// <summary>
        /// Gets a <c>System.String</c> value which represents the OR operation in the WHERE clause.
        /// </summary>
        protected virtual string Or
        {
            get { return "OR"; }
        }
        /// <summary>
        /// Gets a <c>System.String</c> value which represents the EQUAL operation in the WHERE clause.
        /// </summary>
        protected virtual string Equal
        {
            get { return "="; }
        }
        /// <summary>
        /// Gets a <c>System.String</c> value which represents the NOT operation in the WHERE clause.
        /// </summary>
        protected virtual string Not
        {
            get { return "NOT"; }
        }
        /// <summary>
        /// Gets a <c>System.String</c> value which represents the NOT EQUAL operation in the WHERE clause.
        /// </summary>
        protected virtual string NotEqual
        {
            get { return "<>"; }
        }
        /// <summary>
        /// Gets a <c>System.String</c> value which represents the LIKE operation in the WHERE clause.
        /// </summary>
        protected virtual string Like
        {
            get { return "LIKE"; }
        }
        /// <summary>
        /// Gets a <c>System.Char</c> value which represents the place-holder for the wildcard in the LIKE operation.
        /// </summary>
        protected virtual char LikeSymbol
        {
            get { return '%'; }
        }
        #endregion
        private bool startsWith = false;
        private bool endsWith = false;
        private bool contains = false;
        private Dictionary<string, object> parameterValues = new Dictionary<string, object>();
        private StringBuilder sb = new StringBuilder();
        private void Out(string s)
        {
            sb.Append(s);
        }
        //private string ParameterChar = "@";
        #region Protected Methods
        /// <summary>
        /// Visits the children of <see cref="System.Linq.Expressions.BinaryExpression"/>.
        /// </summary>
        /// <param name="node">The expression to visit.</param>
        /// <returns>The modified expression, if it or any subexpression was modified; otherwise,
        /// returns the original expression.</returns>
        protected override Expression VisitBinary(BinaryExpression node)
        {
            string str;
            switch (node.NodeType)
            {
                case ExpressionType.Add:
                    str = "+";
                    break;
                case ExpressionType.AddChecked:
                    str = "+";
                    break;
                case ExpressionType.AndAlso:
                case ExpressionType.And:
                    str = this.And;
                    break;
                case ExpressionType.Divide:
                    str = "/";
                    break;
                case ExpressionType.Equal:
                    str = this.Equal;
                    if (node.Right.NodeType == ExpressionType.Convert && node.Right.ToString() == "Convert(null)")
                    {
                        str = " IS ";
                    }
                    break;
                case ExpressionType.GreaterThan:
                    str = ">";
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    str = ">=";
                    break;
                case ExpressionType.LessThan:
                    str = "<";
                    break;
                case ExpressionType.LessThanOrEqual:
                    str = "<=";
                    break;
                case ExpressionType.Modulo:
                    str = "%";
                    break;
                case ExpressionType.Multiply:
                    str = "*";
                    break;
                case ExpressionType.MultiplyChecked:
                    str = "*";
                    break;
                case ExpressionType.Not:
                    str = this.Not;
                    break;
                case ExpressionType.NotEqual:
                    str = this.NotEqual;
                    break;
                case ExpressionType.OrElse:
                case ExpressionType.Or:
                    str = this.Or;
                    break;
                case ExpressionType.Subtract:
                    str = "-";
                    break;
                case ExpressionType.SubtractChecked:
                    str = "-";
                    break;
                default:
                    throw new NotSupportedException("不支持异常");
            }
            Out("(");
            Visit(node.Left);
            Out(" ");
            Out(str);
            Out(" ");
            Visit(node.Right);
            Out(")");

            return node;
        }
        /// <summary>
        /// Visits the children of <see cref="System.Linq.Expressions.MemberExpression"/>.
        /// </summary>
        /// <param name="node">The expression to visit.</param>
        /// <returns>The modified expression, if it or any subexpression was modified; otherwise,
        /// returns the original expression.</returns>
        protected override Expression VisitMember(MemberExpression node)
        {
            //if (node.Member is FieldInfo)
            //{
            //    ConstantExpression ce = node.Expression as ConstantExpression;
            //    FieldInfo fi = node.Member as FieldInfo;
            //    object fieldValue = fi.GetValue(ce.Value);
            //    Out(node.Member.Name);
            //    //Expression constantExpr = Expression.Constant(fieldValue,node.Type);
            //    //Visit(constantExpr);
            //}
            //else if (node.Member is PropertyInfo)
            //{
            //    if (node.Expression is ConstantExpression)
            //    {
            //        ConstantExpression ce = node.Expression as ConstantExpression;
            //        PropertyInfo pi = node.Member as PropertyInfo;
            //        object fieldValue = pi.GetValue(ce.Value);
            //        Expression constantExpr = Expression.Constant(fieldValue);
            //        Visit(constantExpr);
            //    }
            //}
            //else
            //    throw new NotSupportedException("不支持");
            //return node;
            if (node.Expression is ConstantExpression)
            {
                object obj = (node.Expression as ConstantExpression).Value;
                if (node.Member is FieldInfo)
                {
                    var value = (node.Member as FieldInfo).GetValue(obj);
                    if (value is string || value is DateTime || value is Guid)
                    {
                        Out("'" + value.ToString() + "'");
                    }
                    else
                    {
                        Out(value.ToString());
                    }
                    return Expression.Constant(value, node.Type);
                }
                else if (node.Member is PropertyInfo)
                {
                    var value = (node.Member as PropertyInfo).GetValue(obj, null);
                    Out(node.Member.Name);
                    return Expression.Constant(value, node.Type);
                }
            }
            else if (node.Expression is ParameterExpression)
            {
                Out(node.Member.Name);
            }
            return base.VisitMember(node);
        }
        /// <summary>
        /// Visits the children of <see cref="System.Linq.Expressions.ConstantExpression"/>.
        /// </summary>
        /// <param name="node">The expression to visit.</param>
        /// <returns>The modified expression, if it or any subexpression was modified; otherwise,
        /// returns the original expression.</returns>
        protected override Expression VisitConstant(ConstantExpression node)
        {
            object v = null;
            if (startsWith && node.Value is string)
            {
                startsWith = false;
                v = node.Value.ToString() + LikeSymbol;
            }
            else if (endsWith && node.Value is string)
            {
                endsWith = false;
                v = LikeSymbol + node.Value.ToString();
            }
            else if (contains && node.Value is string)
            {
                contains = false;
                v = LikeSymbol + node.Value.ToString() + LikeSymbol;
            }
            else if (node.Value is string || node.Value is DateTime || node.Value is Guid)
            {
                v = node.Value != null ? node.Value.ToString() : "''";
            }
            else
            {
                v = node.Value != null ? node.Value : "NULL";
            }

            Out(v + "");
            return base.VisitConstant(node);
        }

        /// <summary>
        /// Visits the children of <see cref="System.Linq.Expressions.MethodCallExpression"/>.
        /// </summary>
        /// <param name="node">The expression to visit.</param>
        /// <returns>The modified expression, if it or any subexpression was modified; otherwise,
        /// returns the original expression.</returns>
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            Out("(");
            Visit(node.Object);
            if (node.Arguments == null || node.Arguments.Count != 1)
                throw new NotSupportedException("不支持异常");
            Expression expr = node.Arguments[0];
            switch (node.Method.Name)
            {
                case "StartsWith":
                    startsWith = true;
                    Out(" ");
                    Out(Like);
                    Out(" ");
                    break;
                case "EndsWith":
                    endsWith = true;
                    Out(" ");
                    Out(Like);
                    Out(" ");
                    break;
                case "Equals":
                    Out(" ");
                    Out(Equal);
                    Out(" ");
                    break;
                case "Contains":
                    contains = true;
                    Out(" ");
                    Out(Like);
                    Out(" ");
                    break;
                default:
                    throw new NotSupportedException("不支持异常");
            }
            if (expr is ConstantExpression || expr is MemberExpression)
                Visit(expr);
            else
                throw new NotSupportedException("不支持异常");
            Out(")");
            return node;
        }
        //public static string GetUniqueIdentifier(int length)
        //{
        //    int maxSize = length;
        //    char[] chars = new char[62];
        //    string a;
        //    a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        //    chars = a.ToCharArray();
        //    int size = maxSize;
        //    byte[] data = new byte[1];
        //    RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
        //    crypto.GetNonZeroBytes(data);
        //    size = maxSize;
        //    data = new byte[size];
        //    crypto.GetNonZeroBytes(data);
        //    StringBuilder result = new StringBuilder(size);
        //    foreach (byte b in data)
        //    {
        //        result.Append(chars[b % (chars.Length - 1)]);
        //    }
        //    // Unique identifiers cannot begin with 0-9
        //    if (result[0] >= '0' && result[0] <= '9')
        //    {
        //        return GetUniqueIdentifier(length);
        //    }
        //    return result.ToString();
        //}
        #endregion

        #region public method
        public string ToSqlString()
        {

            sb.Append(Environment.NewLine);
            parameterValues.ToList().ForEach(kvp =>
            {
                sb.Append(string.Format("{0} = [{1}] (Type: {2})", kvp.Key, kvp.Value.ToString(), kvp.Value.GetType().FullName));
                sb.Append(Environment.NewLine);
            });
            return sb.ToString();
        }
        #endregion
    }

}
