using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    [Owned]
    public class ArchivedTask
    {
 
        public int ArchivedTaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ResponsiblePerson { get; set; }
        public string Team { get; set; }
    }
}
