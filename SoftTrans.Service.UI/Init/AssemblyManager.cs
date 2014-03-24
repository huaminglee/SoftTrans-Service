using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SoftTrans.Service.UI
{
    public class AssemblyManager
    {
        #region 公共属性

        #region 程序集属性访问器

        public static string AssemblyTitle
        {
            get
            {
                // 获取此程序集上的所有 Title 属性

                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // 如果至少有一个 Title 属性

                if (attributes.Length > 0)
                {
                    // 请选择第一个属性

                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // 如果该属性为非空字符串，则将其关闭

                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // 如果没有 Title 属性，或者 Title 属性为一个空字符串，则关闭 .exe 的名称

                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyDescription
        {
            get
            {
                // 获取此程序集的所有 Description 属性

                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // 如果 Description 属性不存在，则关闭一个空字符串

                if (attributes.Length == 0)
                    return "";
                // 如果有 Description 属性，则关闭该属性的值

                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                // 获取此程序集上的所有 Product 属性

                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // 如果 Product 属性不存在，则关闭一个空字符串

                if (attributes.Length == 0)
                    return "";
                // 如果有 Product 属性，则关闭该属性的值

                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                // 获取此程序集上的所有 Copyright 属性

                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // 如果 Copyright 属性不存在，则关闭一个空字符串

                if (attributes.Length == 0)
                    return "";
                // 如果有 Copyright 属性，则关闭该属性的值

                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                // 获取此程序集上的所有 Company 属性

                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // 如果 Company 属性不存在，则关闭一个空字符串

                if (attributes.Length == 0)
                    return "";
                // 如果有 Company 属性，则关闭该属性的值

                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        #endregion
    }
}
