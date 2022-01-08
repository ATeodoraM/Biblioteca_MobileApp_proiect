using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Biblioteca_MobileApp.Models
{
    public class BookCategory
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(Book))]
        public int Book_ID { get; set; }

        [ForeignKey(typeof(Category))]
        public int Catgeory_ID { get; set; }

    }
}
