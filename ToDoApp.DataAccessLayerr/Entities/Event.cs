using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.DataAccessLayer.Entities
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        
        [Required,  NotNull]
        public string Title { get; set; }
        [Required, NotNull]
        public string Description { get; set; }
        
        [Required,NotNull]
        public EventType EventType { get; set; }
        
        [Required,NotNull]
        public DateTime DateTime { get; set; }
        
        [Required, NotNull]
        public string Location { get; set; }
        public User Host { get; set; }
 


    }
}
