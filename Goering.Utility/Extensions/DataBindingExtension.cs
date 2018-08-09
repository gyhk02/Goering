using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Goering.Utility
{
    public static class DataBindingExtension
    {
        /// <summary>
        /// 子容器递归方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pControl"></param>
        /// <param name="pModel"></param>
        public static void bingding<T>(Control pControl, T pModel)
        {
            var listControlls = pControl.Controls;
            var listProperties = typeof(T).GetProperties();
            for (int i = 0; i < listControlls.Count; i++)
            {
                if (listControlls[i] is TextBox)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("Text", pModel, listProperties[j].Name);

                        }
                    }
                }

                if (listControlls[i] is ComboBox)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("SelectedValue", pModel, listProperties[j].Name);
                        }
                    }
                }
                if (listControlls[i] is DateTimePicker)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {

                            if (listProperties[j].GetValue(pModel, null) == null || (DateTime)listProperties[j].GetValue(pModel, null) == DateTime.MinValue)
                            {
                                listProperties[i].SetValue(pModel, DateTime.Now, null);
                            }
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("Value", pModel, listProperties[j].Name);
                        }
                    }

                }
                if (listControlls[i].Controls.Count != 0)
                {
                    bingding<T>(listControlls[i], pModel);
                }
            }
        }

        /// <summary>
        /// 绑定model扩展方法
        /// </summary>
        /// <typeparam name="T">需要绑定的model类</typeparam>
        /// <param name="pFrm"></param>
        /// <param name="pModel">model实体</param>
        public static void DataBinding<T>(this System.Windows.Forms.Form pFrm, T pModel)
        {
            var listControlls = pFrm.Controls;
            var listProperties = typeof(T).GetProperties();
            for (int i = 0; i < listControlls.Count; i++)
            {
                if (listControlls[i] is TextBox)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("Text", pModel, listProperties[j].Name);

                        }
                    }
                }

                if (listControlls[i] is ComboBox)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("SelectedValue", pModel, listProperties[j].Name);
                        }
                    }
                }
                if (listControlls[i] is DateTimePicker)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {
                            if (listProperties[j].GetValue(pModel, null) == null || (DateTime)listProperties[j].GetValue(pModel, null) == DateTime.MinValue)
                            {
                                listProperties[i].SetValue(pModel, DateTime.Today, null);
                            }
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("Value", pModel, listProperties[j].Name);
                        }
                    }

                }

                if (listControlls[i].Controls.Count != 0)
                {
                    bingding<T>(listControlls[i], pModel);
                }
            }

        }

        /// <summary>
        /// 绑定model扩展方法
        /// </summary>
        /// <typeparam name="T">需要绑定的model类</typeparam>
        /// <param name="pFrm"></param>
        /// <param name="pControl">目标容器</param>
        /// <param name="pModel">model实体</param>
        public static void DataBinding<T>(this System.Windows.Forms.Form pFrm, System.Windows.Forms.Control pControl, T pModel)
        {
            var listControlls = pControl.Controls;
            var listProperties = typeof(T).GetProperties();
            for (int i = 0; i < listControlls.Count; i++)
            {
                if (listControlls[i] is TextBox)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("Text", pModel, listProperties[j].Name);

                        }
                    }
                }

                if (listControlls[i] is ComboBox)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("SelectedValue", pModel, listProperties[j].Name);
                        }
                    }
                }
                if (listControlls[i] is DateTimePicker)
                {
                    for (int j = 0; j < listProperties.Length; j++)
                    {
                        if (listControlls[i].Name.ToLower().EndsWith(listProperties[j].Name.ToLower()))
                        {
                            if (listProperties[j].GetValue(pModel, null) == null || (DateTime)listProperties[j].GetValue(pModel, null) == DateTime.MinValue)
                            {
                                listProperties[i].SetValue(pModel, DateTime.Today, null);
                            }
                            listControlls[i].DataBindings.Clear();
                            listControlls[i].DataBindings.Add("Value", pModel, listProperties[j].Name);
                        }
                    }

                }

                if (listControlls[i].Controls.Count != 0)
                {
                    bingding<T>(listControlls[i], pModel);
                }
            }

        }
    }
}
