using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataTransferObject
{
    public class ArchivedTaskDTO
    {
        public int ArchivedTaskId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ResponsiblePerson { get; set; }
        public string Team { get; set; }
    }
}
