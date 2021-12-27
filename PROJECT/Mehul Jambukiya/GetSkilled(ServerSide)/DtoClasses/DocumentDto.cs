using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.DtoClasses
{
    public class DocumentDto
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public DateTime LastModified { get; set; }
    }
}
