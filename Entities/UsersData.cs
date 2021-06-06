using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UsersData
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Type { get; set; }
        public string Password { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
