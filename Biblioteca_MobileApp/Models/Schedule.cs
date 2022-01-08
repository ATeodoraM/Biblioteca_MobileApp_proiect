using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca_MobileApp.Models
{
   public class Schedule
    {
        [PrimaryKey,AutoIncrement]
        public int IdSch { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey(typeof(Employees))]
        public int EmployeeID { get; set; }
        [ForeignKey(typeof(Timetable))]
        public int TimetableID { get; set; }
    }
}
