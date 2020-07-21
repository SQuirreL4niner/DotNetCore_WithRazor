using System;
using System.ComponentModel.DataAnnotations;

namespace ToDo_Ex.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "Name should be less than 20 characters")]
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
    }
}