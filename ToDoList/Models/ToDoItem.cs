using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Display(Name = "Itema Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }

        public int StatusId { get; set; }
    }
}