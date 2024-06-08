using System.Configuration;
using System.Reflection;
using System;

namespace OutpatientClinicDoctorModule
{
    /// <summary>
    /// 数据访问层工厂
    /// </summary>
    public class DalFactory
    {
        /// <summary>
        /// 创建数据访问层
        /// </summary>
        /// <returns>数据访问层</returns>
        public static IDoctorDal Create(string type)
        {
            IDoctorDal doctorDal = null;
            switch (type)
            {
                case "Pgsql":
                    doctorDal = new DoctorDalPgsql();
                    break;
                default:
                    doctorDal = new DoctorDalSql();
                    break;
            }
            return doctorDal;
        }
        /// <summary>
        /// 创建数据访问层
        /// </summary>
        /// <typeparam name="TDal">数据访问层类型</typeparam>
        /// <returns>数据访问层</returns>
        public static TDal Create<TDal>()
        {
            string currentNamespace = MethodBase.GetCurrentMethod().DeclaringType.Namespace;
            Type dalInterface = typeof(TDal);
            string dalInterfaceName = dalInterface.Name;
            string modelTypeName = dalInterfaceName.Replace("Dal", "").Substring(1);
            string dalTypeNameSuffix = ConfigurationManager.AppSettings["DalType"];
            string dalFullTypeName = $"{currentNamespace}.{modelTypeName}Dal{dalTypeNameSuffix}";
            Type dalType = Type.GetType(dalFullTypeName);
            TDal dal = (TDal)Activator.CreateInstance(dalType);
            return dal;
        }
    }
}
