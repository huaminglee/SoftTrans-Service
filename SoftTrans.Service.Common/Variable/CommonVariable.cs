using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.Common
{
    /// <summary>
    /// 系统公共变量
    /// </summary>
    public class CommonVariable
    {

        #region 用户信息
        /// <summary>
        /// 当前员工
        /// </summary>
        public static string EMPLOYEE_NAME { get; set; }
        /// <summary>
        /// 当前用户名
        /// </summary>
        public static string USER_CODE { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public static string USER_PASSWORD { get; set; }
        /// <summary>
        /// 当前操作公司编码
        /// </summary>
        public static string OPERATE_COMPANY_CODE { get; set; }
        /// <summary>
        /// 当前操作公司
        /// </summary>
        public static string OPERATE_COMPANY { get; set; }
        /// <summary>
        /// 用户组
        /// </summary>
        public static string USER_DEPT { get; set; }
        #endregion

        #region 系统参数
        /// <summary>
        /// 当前版本号
        /// </summary>
        public static string VERSION { get; set; }
        /// <summary>
        /// 系统导出模板路径
        /// </summary>
        public static string TEMPLATE_FILE_PATH { get; set; }
        /// <summary>
        /// 异常接收邮箱
        /// </summary>
        public static string MAIL_RECEIVER_ADDRESS { get; set; }

        /// <summary>
        /// 发件人邮箱
        /// </summary>
        public static string MAIL_ADDRESS { get; set; }
        /// <summary>
        /// SMTP服务器地址
        /// </summary>
        public static string MAIL_SMTP_HOST { get; set; }
        /// <summary>
        /// SMTP服务器端口
        /// </summary>
        public static int MAIL_SMTP_PORT { get; set; }
        /// <summary>
        /// 发件人密码
        /// </summary>
        public static string MAIL_PASSWORD { get; set; }
        #endregion


        #region 用户设置
        /// <summary>
        /// 导出后是否自动打开文件
        /// </summary>
        public static bool AUTO_OPEN_FILE { get; set; }
        /// <summary>
        /// 网格列自动适应数据宽度
        /// </summary>
        public static bool AUTO_BEST_FITCOLUMNS { get; set; }
        /// <summary>
        /// 记住密码
        /// </summary>
        public static bool REMEMBER_PASSWORD { get; set; }
        /// <summary>
        /// 分页大小
        /// </summary>
        public static int PAGE_SIZE { get; set; }
        /// <summary>
        /// 系统样式
        /// </summary>
        public static string SKIN_NAME { get; set; }
        /// <summary>
        /// 发生错误报告
        /// </summary>
        public static bool SEND_ERROR { get; set; }
        /// <summary>
        /// 记录操作日志
        /// </summary>
        public static bool WRITE_LOG { get; set; }
        #endregion

    

      
     
      
   
      
   
    }
}
