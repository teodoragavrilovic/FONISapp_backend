using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataTransferObject
{
    public class GroupDTO
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Project { get; set; }
        public string Description { get; set; }
        public List<ArchivedTaskDTO> ArchivedTasks { get; set; }
    }
}
