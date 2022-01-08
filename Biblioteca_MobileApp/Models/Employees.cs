using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions;

namespace Biblioteca_MobileApp.Models
{
   public  class Employees
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContractType { get; set; }
        public int Salary { get; set; }
        public string IdentityNR { get; set; }

    }
}
