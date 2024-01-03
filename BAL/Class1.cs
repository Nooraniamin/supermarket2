using ClassLibrary1;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Xml.Linq;

namespace BAL
{
    public class BAL
    {
        
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
            ds.LoadSpParameters("st_deleterole", id);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public override void b_update(int id, string name, int fid)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_updateroles", id, name, fid);
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
    public class categories:branch
    {
        public override void b_insert(string name, int fid)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_insertCategories", name, fid);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public override void b_delete(int id)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_deleteCategories", id);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public override void b_update(int id, string name, int fid)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_updateCategories", id, name, fid);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
    }
    public class product
    {
        public void p_insert(string name , int c_id, double amount, double discount, double a_amount)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_insertproduct", name, c_id,amount,discount,a_amount,1);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public void p_delete( int id)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_deleteproduct", id);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public void p_update(int id,string name, int c_id, double amount, double discount, double a_amount)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_updateproduct",id, name, c_id, amount, discount, a_amount, 1);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
    }
    public class item
    {
        public void i_insert(int billno, int p_id,double price,double discount,double a_amount,int qty,double total,int b_id,int u_id,string date)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_insertitem", billno,p_id, price, discount,a_amount, qty,total, b_id,u_id,date);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public void i_delete(int id)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_deleteitem", id);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
        public void i_update(int id,int billno, int p_id, double price, double discount, double a_amount, int qty, double total, int b_id, int u_id, string date)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_updateitem",id, billno, p_id, price, discount, a_amount, qty, total, b_id, u_id, date);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
    }
    public class customer
    {
        public void cus_insert(string name,string phone,int id = 1)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_insertcustomer", name,phone,id);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
    }
    public class bill
    {
        public void bill_insert(int billno,string billtype,double f_amount, int cusid, int bid, double g_amount = 0,double r_amount=0)
        {
            ClassLibrary1.DDL ds = new ClassLibrary1.DDL();
            ds.OpenConnection();
            ds.LoadSpParameters("st_insertbill", billno ,billtype,f_amount,g_amount,r_amount,cusid,bid);
            ds.ExecuteQuery();
            ds.UnLoadSpParameters();
            ds.CloseConnection();
        }
    }
}