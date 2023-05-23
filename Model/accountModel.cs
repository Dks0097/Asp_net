using Model.Framework;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Model
{
    public class acountModel
    {
        private dbcontext context = null;
        public acountModel()
        {
            context = new dbcontext();
        }
        //login
        public bool Login(string user, string pass,int ?ql)
        {
            object[] sqlParams = { new SqlParameter("@username",user), new SqlParameter("@pass",pass),new SqlParameter("@ql",ql) };
            var res = context.Database.SqlQuery<bool>("Sp_Acount_Login @username,@pass",
            sqlParams).SingleOrDefault();
           
             
            return res;
        }
        
        public List<tbl_account> ListAll()
        {
            var list = context.Database.SqlQuery<tbl_account>("SP_account_listall").ToList();
            return list;
        }
        //
        public int creat(string username, string pass)
        {
            object[] parameters =
            {
             new SqlParameter("@username", username),
             new SqlParameter("@pass", pass)

             };
            int res = context.Database.ExecuteSqlCommand("Sp_Account_Insert @username, @pass", parameters);
            return res;
        }
        public int update(string username, string pass)
        {
            object[] parameters =
            {
                 new SqlParameter("@username", username),
                 new SqlParameter("@pass", pass)

            };
            int res = context.Database.ExecuteSqlCommand("Sp_Account_Update @username, @pass", parameters);
            return res;
        }

        public int delete(string username)
        {
            object[] parameters =
            {
                new SqlParameter("@username",username)

            };
            int res = context.Database.ExecuteSqlCommand("Sp_Account_Delete @username", parameters);
            return res;
        }

        public List<tbl_account> selectID(string username)
        {
            object[] parameters =
            {
             new SqlParameter("@username",username)
            };
            var list = context.Database.SqlQuery<tbl_account>("Sp_Accounts_SelectID @username", parameters).ToList();
            return list;
        }
    }

}