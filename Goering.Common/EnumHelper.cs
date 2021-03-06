﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goering.Common
{
    #region 把枚举写到这里

    #endregion

    public static class EnumHelper
    {
        /// <summary>
        /// 取得枚举的描述信息
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public static string GetEnumDes(this Enum en)
        {
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return en.ToString();
        }

        public static string GetEnumDes<T>(int i)
        {
            var typeInfo = typeof(T);
            FieldInfo[] enumFields = typeInfo.GetFields();
            foreach (var entity in enumFields)
            {
                if (!entity.IsSpecialName)
                {
                    if (i.ToString() == entity.GetRawConstantValue().ToString())
                    {
                        object[] attrs = entity.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                        if (attrs != null && attrs.Length > 0)
                            return ((DescriptionAttribute)attrs[0]).Description;
                    }

                }
            }
            return "";
        }

        /// <summary>
        /// 绑定试用枚举的ComboBox
        /// </summary>
        /// <typeparam name="T">枚举类型</typeparam>
        /// <param name="pComboBox"></param>
        public static void BindToEnum<T>(this ComboBox pComboBox)
        {
            pComboBox.DataSource = null;
            var typeInfo = typeof(T);
            FieldInfo[] enumFields = typeInfo.GetFields();
            DataTable table = new DataTable();
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Value", Type.GetType("System.Int32"));

            DataRow row0 = table.NewRow();
            row0[0] = "请选择";
            row0[1] = "-1";
            table.Rows.Add(row0);

            foreach (var entity in enumFields)
            {
                if (!entity.IsSpecialName)
                {
                    DataRow row = table.NewRow();
                    object[] attrs = entity.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                    var str = ((DescriptionAttribute)attrs[0]).Description;
                    var value = entity.GetRawConstantValue().ToString();
                    row[0] = str;
                    row[1] = value;
                    table.Rows.Add(row);
                }
            }
            pComboBox.DataSource = table;
            pComboBox.DisplayMember = "Name";
            pComboBox.ValueMember = "Value";
        }



        /// <summary>
        /// 绑定使用枚举的DataGridViewComboBoxColumn
        /// </summary>
        /// <typeparam name="T"> 枚举类型</typeparam>
        /// <param name="pComboBox"></param>
        public static void BindToIntEnum<T>(this DataGridViewComboBoxColumn pComboBox)
        {
            pComboBox.DataSource = null;
            var typeInfo = typeof(T);
            FieldInfo[] enumFields = typeInfo.GetFields();
            DataTable table = new DataTable();
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Value", Type.GetType("System.Int32"));

            DataRow row0 = table.NewRow();
            row0[0] = "请选择";
            row0[1] = "-1";
            table.Rows.Add(row0);

            foreach (var entity in enumFields)
            {
                if (!entity.IsSpecialName)
                {
                    DataRow row = table.NewRow();
                    object[] attrs = entity.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                    var str = ((DescriptionAttribute)attrs[0]).Description;
                    var value = entity.GetRawConstantValue().ToString();
                    row[0] = str;
                    row[1] = value;
                    table.Rows.Add(row);
                }
            }
            pComboBox.DataSource = table;
            pComboBox.DisplayMember = "Name";
            pComboBox.ValueMember = "Value";
        }
    }
}
