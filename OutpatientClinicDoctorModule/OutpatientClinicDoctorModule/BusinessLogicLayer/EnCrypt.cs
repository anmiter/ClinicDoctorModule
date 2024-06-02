using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 加密函数
    /// </summary>
    internal class EnCrypt
    {
        /// <summary>
		/// MD5加密
		/// </summary>
		/// <param name="plainText">明文</param>
		/// <returns>密文</returns>
		public static byte[] Md5Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.Default.GetBytes(plainText);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] cryptedBytes = md5.ComputeHash(plainBytes);
            return cryptedBytes;
        }
    }
}
