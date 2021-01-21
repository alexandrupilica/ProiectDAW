using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Entities
{
    public class Producer : BaseEntity
    {
        public string Name { get; set; }
        public string StudioName { get; set; }
        public virtual Song Song { get; set; }

    }
}
