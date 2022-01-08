using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Biblioteca_MobileApp.Models
{
    public class Timetable
    {
        [PrimaryKey,AutoIncrement]
        public int IdTime { get; set; }
        public DateTime OpenHour { get; set; }
        public DateTime CloseHour { get; set; }
    }
}
