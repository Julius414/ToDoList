using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class ItemViewModel
    {
        public IEnumerable<Status> Statuses { get; set; }
        public ToDoItem ToDoItem { get; set; }
    }
}