using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Goering.Utility
{
    public static class DataTableExtension
    {
        #region DataTable 序列化成字符串
        /// <summary>
        /// 序列化DataTable为String
        /// </summary>
        /// <param name="tb">包含数据的DataTable</param>
        /// <returns>序列化的DataTable</returns>
        public static string SerializeDataTableToString(this DataTable tb)
        {
            StringBuilder sb = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(sb);
            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
            serializer.Serialize(writer, tb);
            writer.Close();
            return sb.ToString();
        }
        #endregion

        #region 字符串序列化成DataTable
        /// <summary>
        /// 反序列化String为DataTable
        /// </summary>
        /// <param name="strXml">序列化的DataTable</param>
        /// <returns>DataTable</returns>
        public static DataTable DeserializeStringToDataTable(this string strXml)
        {
            StringReader strReader = new StringReader(strXml);
            XmlReader xmlReader = XmlReader.Create(strReader);
            XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
            DataTable dt = serializer.Deserialize(xmlReader) as DataTable;
            return dt;
        }
        #endregion

        #region DataTable转换成实体类

        /// <summary>  
        /// 填充对象列表：用DataTable填充实体类
        /// </summary>  
        public static List<T> FillModel<T>(this DataTable dt) where T : new()
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            List<T> modelList = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                //T model = (T)Activator.CreateInstance(typeof(T));  
                T model = dr.FillModel<T>();

                modelList.Add(model);
            }
            return modelList;
        }

        /// <summary>  
        /// 填充对象：用DataRow填充实体类
        /// </summary>  
        public static T FillModel<T>(this DataRow dr) where T : new()
        {
            if (dr == null)
            {
                return default(T);
            }

            //T model = (T)Activator.CreateInstance(typeof(T));  
            T model = new T();

            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                PropertyInfo propertyInfo = model.GetType().GetProperty(dr.Table.Columns[i].ColumnName);
                if (propertyInfo != null && dr[i] != DBNull.Value)
                {
                    string v = dr[i].ToString();
                    if (propertyInfo.PropertyType.FullName.ToUpper().Contains("GUID"))
                    {
                        if (!string.IsNullOrEmpty(v))
                        {
                            propertyInfo.SetValue(model, Guid.Parse(v), null);
                        }
                        else
                        {
                            propertyInfo.SetValue(model, null, null);
                        }
                    }
                    else if (propertyInfo.PropertyType.FullName.ToUpper().Contains("BYTE"))
                    {
                        if (!string.IsNullOrEmpty(v))
                        {
                            propertyInfo.SetValue(model, byte.Parse(v), null);
                        }
                        else
                        {
                            propertyInfo.SetValue(model, null, null);
                        }
                    }
                    else
                    {
                        propertyInfo.SetValue(model, dr[i], null);
                    }
                }
            }
            return model;
        }

        #endregion

        #region 实体类转换成DataTable

        /// <summary>
        /// 实体类转换成DataTable
        /// </summary>
        /// <param name="modelList">实体类列表</param>
        /// <returns></returns>
        public static DataTable FillDataTable<T>(this List<T> modelList) where T : new()
        {
            if (modelList == null || modelList.Count == 0)
            {
                return null;
            }
            DataTable dt = CreateData<T>(modelList[0]);

            foreach (T model in modelList)
            {
                DataRow dataRow = dt.NewRow();
                foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
                {
                    dataRow[propertyInfo.Name] = propertyInfo.GetValue(model, null);
                }
                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        /// <summary>
        /// 根据实体类得到表结构
        /// </summary>
        /// <param name="model">实体类</param>
        /// <returns></returns>
        private static DataTable CreateData<T>(T model) where T : new()
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
            {
                dataTable.Columns.Add(new DataColumn(propertyInfo.Name, propertyInfo.PropertyType));
            }
            return dataTable;
        }

        #endregion

        #region DataRow to insert and update sql
        /// <summary>
        /// 将行(DataRow) 转化成插入语句
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="IntoTableName">插入表名</param>
        /// <param name="InsertFields">插入表字段列表</param>
        /// <returns></returns>
        public static string ToInsertSQL(this DataRow row, string IntoTableName, List<string> InsertFields)
        {
            List<string> Fields = new List<string>();
            List<string> Values = new List<string>();
            string InsertSQL = "INSERT INTO " + IntoTableName + "({0}) VALUES ({1})";
            foreach (string field in InsertFields)
            {
                Fields.Add(field);
                Values.Add(row.ToValueString(field));
            }
            return string.Format(InsertSQL, string.Join(",", Fields), string.Join(",", Values));
        }
        /// <summary>
        /// 将行(DataRow) 转化成插入语句
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="IntoTableName">插入表名</param>
        /// <returns></returns>
        public static string ToInsertSQL(this DataRow row, string IntoTableName)
        {
            List<string> Fields = new List<string>();
            List<string> Values = new List<string>();
            string InsertSQL = "INSERT INTO " + IntoTableName + "({0}) VALUES ({1})";
            foreach (DataColumn field in row.Table.Columns)
            {
                Fields.Add(field.ColumnName);
                Values.Add(row.ToValueString(field.ColumnName));
            }
            return string.Format(InsertSQL, string.Join(",", Fields), string.Join(",", Values));
        }

        /// <summary>
        /// 将（DataRow）转化成更新语句
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="UpdateTableName">要更新的表名</param>
        /// <param name="UpdateFields">要更新的字段列表</param>
        /// <param name="keys">主键</param>
        /// <returns></returns>
        public static string ToUpdateSQL(this DataRow row, string UpdateTableName, List<string> UpdateFields, Dictionary<string, string> keys)
        {
            string UpdateSQL = "UPDATE {0} SET {1} {2}"; //0 表名，1 更新字段  2 条件
            List<string> Sets = new List<string>();
            foreach (string field in UpdateFields)
            {
                if (keys.Keys.Contains(field)) continue; //如果 字段属于主键则不用更新
                string set = field + "=" + row.ToValueString(field);
                Sets.Add(set);
            }
            string where = row.BuildWhere(keys);

            return string.Format(UpdateSQL, UpdateTableName, string.Join(",", Sets), where);
        }
        /// <summary>
        /// 将（DataRow）转化成更新语句
        /// </summary>
        /// <param name="row">数据行</param>
        /// <param name="UpdateTableName">要更新的表名</param>
        /// <param name="keys">主键</param>
        /// <returns></returns>
        public static string ToUpdateSQL(this DataRow row, string UpdateTableName, Dictionary<string, string> keys)
        {
            string UpdateSQL = "UPDATE {0} SET {1} {2}"; //0 表名，1 更新字段  2 条件
            List<string> Sets = new List<string>();
            foreach (DataColumn field in row.Table.Columns)
            {
                if (keys.Keys.Contains(field.ColumnName)) continue; //如果 字段属于主键则不用更新
                string set = field + "=" + row.ToValueString(field.ColumnName);
                Sets.Add(set);
            }
            string where = row.BuildWhere(keys);

            return string.Format(UpdateSQL, UpdateTableName, string.Join(",", Sets), where);
        }

        /// <summary>
        /// 将指定列转换成SQL 值字符, 如 '2014-01-01', 0,  False,null 等，需要加引号的给加上引号
        /// </summary>
        /// <param name="dr">数据行</param>
        /// <param name="ColName">列名</param>
        /// <returns></returns>
        public static string ToValueString(this DataRow dr, string ColName)
        {

            string Value = dr[ColName].ToString().Replace("'", "''");
            string VType = dr.Table.Columns[ColName].DataType.ToString().ToLower();
            if (VType.Contains("datetime") || VType.Contains("string") || VType.Contains("guid"))
            {
                if (string.IsNullOrEmpty(Value) && dr[ColName].GetType().ToString().ToLower().Contains("dbnull"))
                {
                    return "NULL"; //如果列值为NULL
                }
                else
                {
                    return string.Format("'{0}'", Value);
                }
            }

            if (VType.Contains("int") || VType.Contains("bool"))
            {
                if (string.IsNullOrEmpty(Value) && dr[ColName].GetType().ToString().ToLower().Contains("dbnull"))
                {
                    return "NULL"; //如果列值为NULL
                }
                else
                {
                    return Value;
                }
            }
            return Value;
        }

        /// <summary>
        /// 将指定列转换成SQL 值字符, 如 '2014-01-01', 0,  False,null 等，需要加引号的给加上引号
        /// </summary>
        /// <param name="dr">数据行</param>
        /// <param name="ColIndex">列序号</param>
        /// <returns></returns>
        public static string ToValueString(this DataRow dr, int ColIndex)
        {
            string Value = dr[ColIndex].ToString().Replace("'", "''");
            string VType = dr.Table.Columns[ColIndex].DataType.ToString().ToLower();
            if (VType.Contains("datetime") || VType.Contains("string") || VType.Contains("guid"))
            {
                if (string.IsNullOrEmpty(Value) && dr[ColIndex].GetType().ToString().ToLower().Contains("dbnull"))
                {
                    return "NULL"; //如果列值为NULL
                }
                else
                {
                    return string.Format("'{0}'", Value);
                }
            }

            if (VType.Contains("int") || VType.Contains("bool"))
            {
                if (string.IsNullOrEmpty(Value) && dr[ColIndex].GetType().ToString().ToLower().Contains("dbnull"))
                {
                    return "NULL"; //如果列值为NULL
                }
                else
                {
                    return Value;
                }
            }
            return Value;
        }

        /// <summary>
        /// 根据给定的字典，生成WHERE条件，如果字典是空，则返回空串
        /// </summary>
        /// <param name="dr">数据行</param>
        /// <param name="keys">条件字段列表：key 为条件字段，value 为从数据行中读取字段</param>
        /// <returns>生成带"WHERE"关键字的条件语句，如： WHERE ID=1 </returns>
        public static string BuildWhere(this DataRow dr, Dictionary<string, string> keys)
        {
            List<string> wheres = new List<string>();
            foreach (var item in keys)
            {
                wheres.Add(item.Key + "=" + dr.ToValueString(item.Value));
            }
            string where = string.Join(" AND ", wheres);
            if (!string.IsNullOrEmpty(where)) where = " WHERE " + where;
            return where;
        }
        #endregion
    }
}
