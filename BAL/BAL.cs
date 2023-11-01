using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BAL
{
    public class BAL
    {
        private static string name;
        public static string user
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        public static bool isValidUser(string user,string password)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            bool status = false;
            try 
            {
                ds.OpenConnection();
                ds.LoadSpParameters("st_getdata",user,password);
                ds.GetDataReader();
                ds.CloseConnection();
                status = true;
            }
            catch(Exception ex) 
            {
                string ax = ex.Message; 
            }
            return status;
        }
    }
}
