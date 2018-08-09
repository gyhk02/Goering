using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Goering.Utility
{
    public class ConfigHelper
    {
        //private static Log.ILogger logger = new Log.Logger();
        /// <summary>
        /// xml配置文件路径
        /// </summary>
        private static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EvervanConfig.xml");


        /// <summary>
        /// 取得AppSetting值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSettings(string key)
        {
            string result = string.Empty;

            try
            {
                result = GetAppSettingsFromAppConfig(key);
            }
            catch
            {
                result = GetAppSettingsFromXml(key);
            }
            return result;
        }

        /// <summary>
        /// 取得连接字符串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetconnectionStrings(string name)
        {
            string result = string.Empty;

            try
            {
                result = GetconnectionStringsFromAppConfig(name);
            }
            catch
            {
                result = GetconnectionStringsFromXml(name);
            }
            return result;
        }

        /// <summary>
        /// 从配置文件读取AppSettings
        /// </summary>
        /// <returns></returns>
        public static string GetAppSettingsFromAppConfig(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// 从配置文件读取connectionStrings
        /// </summary>
        /// <returns></returns>
        public static string GetconnectionStringsFromAppConfig(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


        /// <summary>
        /// 从xml文件取得appSettings值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSettingsFromXml(string key)
        {
            string result = string.Empty;

            System.Xml.XmlAttribute att = XMLHelper.GetXmlAttribute(configPath, "/configuration/appSettings/add[@key=\"" + key + "\"]", "value");
            result = att.Value;
            return result;
        }

        /// <summary>
        /// 从xml文件取得connectionStrings值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetconnectionStringsFromXml(string name)
        {
            string result = string.Empty;

            System.Xml.XmlAttribute att = XMLHelper.GetXmlAttribute(configPath, "/configuration/connectionStrings/add[@name=\"" + name + "\"]", "connectionString");
            result = att.Value;

            return result;
        }
    }
}
