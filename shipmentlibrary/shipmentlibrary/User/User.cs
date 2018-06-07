using System;
using System.Collections.Generic;
using System.Text;

namespace shipmentlibrary.User
{
    public class User
    {
        protected int userid;
        protected string name;
        protected string email;
        protected string mobile_no;
        protected string pwd;
        protected string source;
        protected string pay_id;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile_no { get; set; }
        public string Pay_id { get; set; }
        public string Source { get; set; }
        public void Login()
        {
            Console.WriteLine("Enter the username: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the password");
            pwd = Console.ReadLine();
            Console.WriteLine("welcome " + name);
        }
    }
}
