using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignPatternProjet.Models
{
    public static class SingletonDB
    {
        private static DB_VehiculesEntities dbVE;

        public static DB_VehiculesEntities Instance
        {
            get
            {
                if (dbVE == null)
                {
                    dbVE = new DB_VehiculesEntities();
                }

                return dbVE;
            }
        }

  
    }
}