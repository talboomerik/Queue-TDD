using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueBehavior
{
    class item
    {
        public item(int value)
        {
            this.Value = value;
        }

        public int? Value { get; private set; }

        public item NextItem { get; set; }
    }
}
