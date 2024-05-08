using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class User
    {
        private static readonly Lazy<User> instance = new Lazy<User>(() => new User());
        public string Username { get; set; }
        private User() { }
        public static User GetInstance()
        {
            return instance.Value;
        }
    }
}
