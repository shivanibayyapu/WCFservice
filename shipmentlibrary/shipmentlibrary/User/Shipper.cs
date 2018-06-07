using System;
using System.Collections.Generic;
using System.Text;

namespace shipmentlibrary.User
{
    class Shipper
    {
        public int order_id = 0;
        public string usname;
        private string Pwd { get; set; }
        public string Usname { get; set; }

        public void Place_order()
        {
            Console.WriteLine("List of Products");
            Console.WriteLine("Product1");
            Console.WriteLine("Product2");
            Console.WriteLine("Product3");
            order_id = Console.Read();
            Console.WriteLine(order_id);
        }

    }
}
