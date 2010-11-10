using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueBehavior
{
    class Queue
    {
        private item firstItem;
        private item lastItem;
        
        public bool IsEmpty()
        {
            return (firstItem == null);
        }

        public int Dequeue()
        {
            if (firstItem != null)
            {
                var returnItem = firstItem.Value;
                firstItem = firstItem.NextItem;
                return returnItem.Value;
            }
            throw new ActionNotAllowedException();
        }

        public void Enqueue(int i)
        {
            if (firstItem == null)
            {
                firstItem = new item(i);
                lastItem = firstItem;
            }
            else
            {
                var newItem = new item(i);
                lastItem.NextItem = newItem;
                lastItem = newItem;
            }
        }
    }
}
