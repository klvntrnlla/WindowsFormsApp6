using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public abstract class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool VerifyLogin(string id, string pass)
        {
            return id.Equals(this.user_id) && pass.Equals(this.user_password);
        }

        public abstract void UpdatePassword(string newPassword);
    }

    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            this.admin_name = name;
        }

        public override void UpdatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }

        public void UpdateAdminName(string name)
        {
            this.admin_name = name;
        }
    }
}