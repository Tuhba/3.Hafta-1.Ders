using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw.Entities
{
    internal class Review : EntityBase<Guid>
    {
        public string Text {  get; set; }
        public int Rating { get; set; } 
    }
}
