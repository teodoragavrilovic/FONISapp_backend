using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataTransferObject
{
    public class TeamDTO
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
    }
}
