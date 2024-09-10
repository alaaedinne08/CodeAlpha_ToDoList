using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDO
    {
        public int Id {get; set;}
        public string Descreption { get; set;}
        public bool IsDONE { get; set; }
        public virtual ApplicationUser User {  get; set; }


    }
}