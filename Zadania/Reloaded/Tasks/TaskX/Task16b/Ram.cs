using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloaded.Tasks.TaskX.Task16b
{
    public class Ram
    {
        public Ram(RamType ramType, int size)
        {
            RamType = ramType;
            Size = size;
        }
        public RamType RamType { get; set; }
        public int Size { get; set; }
    }
    public enum RamType
    {
        DDR2,
        DDR3,
        DDR4,
    }
}
