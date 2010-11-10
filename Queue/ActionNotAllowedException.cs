using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueBehavior
{
    class ActionNotAllowedException : Exception
    {
        public ActionNotAllowedException() : base("This action is not allowed") { }
    }
}
