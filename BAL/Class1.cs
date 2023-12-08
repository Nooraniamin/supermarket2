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

        public static void isValidUser(string User, string password)
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
            catch (Exception ex)
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
        public virtual void b_update(int id, string name, int fid)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_updatebranch", id, name, fid);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }

    }
    public class roles : branch
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
    public class user
    {
        public void u_insert(string name, int cnic,int salary,int b_id,int r_id,string u_name,string pass, string c_pass)
        {
            int cmp = 1;
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_insertuser", name, cnic,salary,b_id,r_id,u_name,pass,c_pass,cmp);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public void u_delete(int id)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_userdelete", id);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public void u_update(int id,string name, int cnic, int salary, int b_id, int r_id, string u_name, string pass, string c_pass)
        {
            int cmp = 1;
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_userupdate", id,name, cnic, salary, b_id, r_id, u_name, pass, c_pass, cmp);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
    }
}