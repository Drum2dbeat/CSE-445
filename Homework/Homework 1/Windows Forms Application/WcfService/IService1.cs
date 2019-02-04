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
    
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Password(string first_name, string last_name, int age);

        [OperationContract]
        int LoginID(int age);

    }
}
