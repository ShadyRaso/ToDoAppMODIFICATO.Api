using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.DataAccessLayer.Entities
{
    
    public class EventType
    {
        [Key]
        public int Id { get; set; }

        [DisallowNull]
        public string Name { get; set; }

        [Required]
        public int EntrantNumber { get; set; }
        [Required, NotNull]
        public byte[] ProfileImage { get; set; }
    }
}
