using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.CRUD.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Class { get; set; }
    }  

}