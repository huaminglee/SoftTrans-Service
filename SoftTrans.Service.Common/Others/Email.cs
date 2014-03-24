
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace SoftTrans.Service.Common
{
    public class Email
    {
        #region 属性
        /// <summary>
        /// 发送者
        /// </summary>
        public string mailFrom { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public string[] mailToArray { get; set; }

        /// <summary>
        /// 抄送
        /// </summary>
        public string[] mailCcArray { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string mailSubject { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        public string mailBody { get; set; }

        /// <summary>
        /// 发件人密码
        /// </summary>
        public string mailPwd { get; set; }

        /// <summary>
        /// SMTP邮件服务器
        /// </summary>
        public string host { get; set; }

        /// <summary>
        /// SMTP服务器端口
        /// </summary>
        public int HostPort { get; set; }

        /// <summary>
        /// 正文是否是html格式
        /// </summary>
        public bool isbodyHtml { get; set; }



        /// <summary>
        /// 附件
        /// </summary>
        public string[] attachmentsPath { get; set; }
        #endregion

        public Email(string subject, string body)
        {
            this.host = CommonVariable.MAIL_SMTP_HOST;
            this.isbodyHtml = true;
            this.mailBody = body;
            this.mailFrom = CommonVariable.MAIL_ADDRESS;
            this.mailPwd = CommonVariable.MAIL_PASSWORD;
            this.mailSubject = subject;
            this.mailToArray = new string[] { CommonVariable.MAIL_RECEIVER_ADDRESS };
        }

        public void Send()
        {
            //使用指定的邮件地址初始化MailAddress实例
            MailAddress maddr = new MailAddress(mailFrom);
            //初始化MailMessage实例
            MailMessage myMail = new MailMessage();


            //向收件人地址集合添加邮件地址
            if (mailToArray != null)
            {
                for (int i = 0; i < mailToArray.Length; i++)
                {
                    myMail.To.Add(mailToArray[i].ToString());
                }
            }

            //向抄送收件人地址集合添加邮件地址
            if (mailCcArray != null)
            {
                for (int i = 0; i < mailCcArray.Length; i++)
                {
                    myMail.CC.Add(mailCcArray[i].ToString());
                }
            }
            //发件人地址
            myMail.From = maddr;

            //电子邮件的标题
            myMail.Subject = mailSubject;

            //电子邮件的主题内容使用的编码
            myMail.SubjectEncoding = Encoding.UTF8;

            //电子邮件正文
            myMail.Body = mailBody;

            //电子邮件正文的编码
            myMail.BodyEncoding = Encoding.Default;

            myMail.Priority = MailPriority.High;

            myMail.IsBodyHtml = isbodyHtml;

            //在有附件的情况下添加附件
            try
            {
                if (attachmentsPath != null && attachmentsPath.Length > 0)
                {
                    Attachment attachFile = null;
                    foreach (string path in attachmentsPath)
                    {
                        attachFile = new Attachment(path);
                        myMail.Attachments.Add(attachFile);
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception("在添加附件时有错误:" + err);
            }

            SmtpClient smtp = new SmtpClient();
            //指定发件人的邮件地址和密码以验证发件人身份
            smtp.Credentials = new System.Net.NetworkCredential(mailFrom, mailPwd);
            //设置SMTP邮件服务器
            smtp.Host = host;
            //设置SMTP端口号
            try
            {
                //将邮件发送到SMTP邮件服务器
                smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                smtp.SendAsync(myMail, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        bool mailSent = false;

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {

            if (e.Cancelled)
            {
                //取消操作
            }
            if (e.Error != null)
            {
                //发生异常
                throw (e.Error);
            }
            else
            {
                MessageBox.Show("发送成功！");
            }


        }



    }
}
