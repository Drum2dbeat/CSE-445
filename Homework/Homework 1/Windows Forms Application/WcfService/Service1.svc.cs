using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

/*
 *  Name:   Oscar Jara 
 *  Date:   2/1/19
 *  Class:  CSE 445
 */

namespace WcfService1
{
    
    public class Service1 : IService1
    {
        
        public string Password(string first_name, string last_name, int age)
        {
            string p1 = last_name.Substring(0, 2);
            string p2 = first_name.Substring(first_name.Length - 2, 2);

            int id = age % 5;
            string p3 = p1 + p2 + id;
            return p3;
        }

        public int LoginID(int age)
        {
            Random rand = new Random();
            int num = rand.Next(100, 200);
            int login = age * num;
            return login;

        }

    }
}
