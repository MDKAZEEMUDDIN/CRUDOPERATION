using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CansolecrudapplicationSQL
{
    public class Program
    {
        static void Main(string[] args)
        {
            Crudoperation crudoperation = new Crudoperation();
            crudoperation.RetriveUser();
           // crudoperation.CreateUser();
            crudoperation.UpdateUser(); 
           // crudoperation.DeleteUser();


        }






    }
}

