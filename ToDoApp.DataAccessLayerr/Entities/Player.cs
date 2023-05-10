using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.DataAccessLayer.Entities
{
    [Keyless]
    public class Player
    {
        public Event Event { get; set; }
        public Users User { get; set; }
        public Team Team { get; set; }
    }
}