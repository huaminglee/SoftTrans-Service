using CYQ.Data;
using DevExpress.LookAndFeel;
using SoftTrans.Service.Common;
using SoftTrans.Service.Common.UI;
using SoftTrans.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.UI
{
    public class InitUserConfig
    {


        public static void SetValue(string key, string value)
        {
            using (UserConfig config = new UserConfig())
            {

                if (config.Fill(string.Format("Key='{0}'", key)))
                {
                    config.Value = value;
                    config.Update();
                }
                else
                {
                    config.Key = key;
                    config.Value = value;
                    config.Insert(InsertOp.None);
                }
            }
        }




        public static string GetValue(string key)
        {
            string value = string.Empty;

            using (UserConfig config = new UserConfig())
            {
                if (config.Fill(string.Format("Key='{0}'", key)))
                {
                    value = config.Value;
                }
            }
            return value;
        }


        /// <summary>
        /// 加载用户设置
        /// </summary>
        public static void Init()
        {
            CommonVariable.AUTO_BEST_FITCOLUMNS = GetValue("AUTO_BEST_FITCOLUMNS") == "" ? true : Convert.ToBoolean(GetValue("AUTO_BEST_FITCOLUMNS"));
            CommonVariable.AUTO_OPEN_FILE = GetValue("AUTO_OPEN_FILE") == "" ? true : Convert.ToBoolean(GetValue("AUTO_OPEN_FILE"));
            CommonVariable.MAIL_ADDRESS = GetValue("MAIL_ADDRESS");
            CommonVariable.MAIL_PASSWORD = GetValue("MAIL_PASSWORD");
            CommonVariable.MAIL_RECEIVER_ADDRESS = GetValue("MAIL_RECEIVER_ADDRESS");
            CommonVariable.MAIL_SMTP_HOST = GetValue("MAIL_SMTP_HOST");
            CommonVariable.MAIL_SMTP_PORT = GetValue("MAIL_SMTP_PORT") == "" ? 0 : Convert.ToInt32(GetValue("MAIL_SMTP_PORT"));
            CommonVariable.TEMPLATE_FILE_PATH = GetValue("TEMPLATE_FILE_PATH");
            CommonVariable.OPERATE_COMPANY_CODE = GetValue("OPERATE_COMPANY_CODE");
            CommonVariable.EMPLOYEE_NAME = GetValue("EMPLOYEE_NAME");
            CommonVariable.OPERATE_COMPANY = GetValue("OPERATE_COMPANY");
            CommonVariable.USER_CODE = GetValue("USER_CODE");
            CommonVariable.USER_DEPT = GetValue("USER_DEPT");
            CommonVariable.VERSION = GetValue("VERSION");
            CommonVariable.USER_PASSWORD = GetValue("USER_PASSWORD");
            CommonVariable.REMEMBER_PASSWORD = GetValue("REMEMBER_PASSWORD") == "" ? false : true;
            CommonVariable.PAGE_SIZE = GetValue("PAGE_SIZE") == "" ? 50 : Convert.ToInt32(GetValue("PAGE_SIZE"));
            CommonVariable.SKIN_NAME = GetValue("SKIN_NAME") == "" ? "Office 2013" : GetValue("SKIN_NAME");
            CommonVariable.WRITE_LOG = GetValue("WRITE_LOG") == "" ? false : true;
            CommonVariable.SEND_ERROR = GetValue("SEND_ERROR") == "" ? false : true;
            UserLookAndFeel.Default.SetSkinStyle(CommonVariable.SKIN_NAME);


        }

        /// <summary>
        /// 设置默认配置
        /// </summary>
        public static void SetDefaultConfig()
        {
            SetValue("AUTO_BEST_FITCOLUMNS", "true");
            SetValue("AUTO_OPEN_FILE", "true");
            SetValue("EMPLOYEE_NAME", "anonymous");
            SetValue("MAIL_ADDRESS", "liuzhiquan@cnebt.com");
            SetValue("MAIL_PASSWORD", "Popeyelau11");
            SetValue("MAIL_RECEIVER_ADDRESS", "popeyelau@qq.com");
            SetValue("MAIL_SMTP_HOST", "mail.softtrans.com");
            SetValue("MAIL_SMTP_PORT", "0");
            SetValue("OPERATE_COMPANY", "undefinition");
            SetValue("OPERATE_COMPANY_CODE", "undefinition");
            SetValue("TEMPLATE_FILE_PATH", "Template");
            SetValue("USER_CODE", "anonymous");
            SetValue("USER_DEPT", "undefinition");
            SetValue("VERSION", AssemblyManager.AssemblyVersion);
            SetValue("USER_PASSWORD", "");
            SetValue("REMEMBER_PASSWORD", "false");
            SetValue("PAGE_SIZE", "50");
            SetValue("SKIN_NAME", "Office 2013");
            SetValue("WRITE_LOG", "false");
            SetValue("SEND_ERROR", "false");
            UserLookAndFeel.Default.SetSkinStyle(CommonVariable.SKIN_NAME);
        }

        /// <summary>
        /// 保存用户配置
        /// </summary>
        public static void SetCustomerSettings()
        {
            SetValue("AUTO_BEST_FITCOLUMNS", CommonVariable.AUTO_BEST_FITCOLUMNS.ToString());
            SetValue("AUTO_OPEN_FILE", CommonVariable.AUTO_OPEN_FILE.ToString());
            SetValue("EMPLOYEE_NAME", CommonVariable.EMPLOYEE_NAME);
            SetValue("MAIL_ADDRESS", CommonVariable.MAIL_ADDRESS);
            SetValue("MAIL_PASSWORD", CommonVariable.MAIL_PASSWORD);
            SetValue("MAIL_RECEIVER_ADDRESS", CommonVariable.MAIL_RECEIVER_ADDRESS);
            SetValue("MAIL_SMTP_HOST", CommonVariable.MAIL_SMTP_HOST);
            SetValue("MAIL_SMTP_PORT", CommonVariable.MAIL_SMTP_PORT.ToString() == "" ? "0" : CommonVariable.MAIL_SMTP_PORT.ToString());
            SetValue("OPERATE_COMPANY", CommonVariable.OPERATE_COMPANY);
            SetValue("OPERATE_COMPANY_CODE", CommonVariable.OPERATE_COMPANY_CODE);
            SetValue("TEMPLATE_FILE_PATH", CommonVariable.TEMPLATE_FILE_PATH);
            SetValue("USER_CODE", CommonVariable.USER_CODE);
            SetValue("USER_DEPT", CommonVariable.USER_DEPT);
            SetValue("VERSION", AssemblyManager.AssemblyVersion);
            SetValue("USER_PASSWORD", CommonVariable.USER_PASSWORD);
            SetValue("REMEMBER_PASSWORD", CommonVariable.REMEMBER_PASSWORD.ToString());
            SetValue("PAGE_SIZE", CommonVariable.PAGE_SIZE.ToString());
            SetValue("SKIN_NAME", CommonVariable.SKIN_NAME);
            SetValue("WRITE_LOG", CommonVariable.WRITE_LOG.ToString());
            SetValue("SEND_ERROR", CommonVariable.SEND_ERROR.ToString());


        }
    }

}
