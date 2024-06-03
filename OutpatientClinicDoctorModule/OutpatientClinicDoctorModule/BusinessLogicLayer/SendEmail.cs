using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 发送邮箱函数
    /// </summary>
    internal class SendEmail
    {
        private static readonly Random rnd = new Random(); // 静态只读字段，确保只创建一个Random实例  
        /// <summary>  
        /// 生成随机验证码  
        /// </summary>  
        /// <param name="codeLength">验证码长度</param>  
        /// <returns>生成的随机验证码字符串</returns>  
        public static string CreateRandomMailCode(int codeLength)
        {
            const string valid = "0123456789"; // 有效的验证码字符集    
            StringBuilder result = new StringBuilder();
            while (result.Length < codeLength)
            {
                result.Append(valid[rnd.Next(valid.Length)]);
            }
            return result.ToString();
        }
        /// <summary>
        ///  发送邮件验证码
        /// </summary>
        /// <param name="MyEmailAddress">发件人邮箱地址</param>
        /// <param name="RecEmailAddress">收件人邮箱地址</param>
        /// <param name="Subject">邮件主题</param>
        /// <param name="MailContent">邮件内容</param>
        /// <param name="AuthorizationCode">邮箱授权码</param>
        /// <returns></returns>
        public static bool SendMailMessage(string MyEmailAddress, string RecEmailAddress, string Subject, string Body, string AuthorizationCode)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(MyEmailAddress);//发件人邮箱地址
            mail.To.Add(new MailAddress(RecEmailAddress));//收件人邮箱地址
            mail.Subject = Subject;//邮件标题
            mail.Body = Body;  //邮件内容  
            mail.Priority = MailPriority.High;//优先级
            SmtpClient client = new SmtpClient();//qq邮箱:smtp.qq.com；126邮箱:smtp.126.com              
            client.Host = "smtp.qq.com";
            client.Port = 587;//SMTP端口465或587
            client.EnableSsl = true;//使用安全加密SSL连接  
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(MyEmailAddress, AuthorizationCode);//验证发件人身份(发件人邮箱，邮箱授权码);                   
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
