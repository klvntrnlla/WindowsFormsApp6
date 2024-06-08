using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Player : User
    {
        public Player(string id, string pass) : base(id, pass)
        {
        }
        public string GetUserId()
        {
            var fieldInfo = typeof(User).GetField("user_id", BindingFlags.NonPublic | BindingFlags.Instance);
            return (string)fieldInfo.GetValue(this);
        }

        public override void UpdatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }
    }
}
   