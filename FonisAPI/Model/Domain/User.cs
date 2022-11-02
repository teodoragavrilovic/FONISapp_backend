using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public bool Admin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool NewPass { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
