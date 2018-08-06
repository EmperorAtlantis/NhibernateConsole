using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class HbmHelper
    {
        private static ISessionFactory _sessionFactory;
        public static ISessionFactory CurrentSessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    //创建SessionFactory
                    _sessionFactory = new Configuration().Configure().BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }
    }
}
