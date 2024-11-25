using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Interfaces;

namespace Business
{
    public class Buser
    {

        //private Duser objData = new Duser();
        //public List<User> ListUser()
        //{
        //    return objData.ListUser();
        //}

        public List<User> ListUser() => new Duser().ListUser();

    }
}
