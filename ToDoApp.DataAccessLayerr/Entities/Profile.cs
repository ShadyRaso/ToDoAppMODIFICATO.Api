using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace ToDoApp.DataAccessLayer.Entities
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        [AllowNull]
        public string Name { get; set; }
        [AllowNull]
        public string Surname { get; set; }
        [AllowNull]
        public DateTime Birthdate { get; set; }
        [AllowNull]
        public string Address { get; set; }
        [AllowNull]
        public string City { get; set; }
    }
}
