using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class ContainableItem : Product, AuditableItem<ContainableItem>
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Size { get; set; }
    }
}
