
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SoftTrans.Service.Common
{
    public class LogHelper
    {

        /// <summary>
        /// 系统日记
        /// </summary>
        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
        /// <summary>
        /// 错误日志
        /// </summary>
        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");


        /// <summary>
        /// 消息记录
        /// </summary>
        /// <param name="info"></param>
        public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }




        /// <summary>
        /// 错误记录
        /// </summary>
        /// <param name="info">附加信息</param>
        /// <param name="ex">错误</param>
        public static void ErrorLog(string info, Exception ex)
        {
            if (!string.IsNullOrEmpty(info) && ex == null)
            {
                logerror.ErrorFormat("【附加信息】：{0}", info);
            }
            else if (!string.IsNullOrEmpty(info) && ex != null)
            {
                string errorMsg = BuildErrorMsg(ex);
                logerror.ErrorFormat("【附加信息】：{0} \r\n{1}", new object[] { info, errorMsg });
            }
            else if (string.IsNullOrEmpty(info) && ex != null)
            {
                string errorMsg = BuildErrorMsg(ex);
                logerror.Error(errorMsg);
            }
        }
        /// <summary>
        /// 返回异常消息
        /// </summary>
        /// <param name="ex">异常</param>
        /// <returns>错误信息</returns>
        private static string BuildErrorMsg(Exception ex)
        {
            string errorMsg = string.Format("【异常类型】：{0} \r\n【异常信息】：{1} \r\n【堆栈调用】：{2} \r\n", ex.GetType().Name, ex.Message, ex.StackTrace);
            return errorMsg;
        }
    }
}
