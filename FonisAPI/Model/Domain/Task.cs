using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  string ResponsiblePerson { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int BacklogPosition { get; set; }
        public int BoardPosition { get; set; }
        public bool Deleted { get; set; }
    }
}
