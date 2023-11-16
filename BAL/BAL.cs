using ClassLibrary1;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;

namespace BAL
{
    public class BAL
    {
        public static string ID;
        private static string name;
        
        public static void isValidUser(string User,string password)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            
            try 
            {
                ds.OpenConnection();
                ds.LoadSpParameters("st_getuser", User, password);
                ds.ExecuteQuery();
                ds.UnLoadSpParameters();
                ds.CloseConnection(); 
                name = User;
            }
            catch(Exception ex) 
            {
                string ax = ex.Message; 
            }
            
        }
        
    }
    public class branch
    {
        public virtual void b_insert(string name, int fid)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_insertbranch", name, fid);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public virtual void b_delete(int id)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_deletebranch", id);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public virtual void b_update(int id,string name, int fid)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_updatebranch", id,name,fid);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        
    }
    public class roles:branch
    {
        public override void b_insert(string name, int fid)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_insertrole", name, fid);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public override void b_delete(int id)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_deletebranch", id);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public override void b_update(int id, string name, int fid)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_updatebranch", id, name, fid);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
    }
}
