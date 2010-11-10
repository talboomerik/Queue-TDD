using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueBehavior;

namespace QueueBehavior
{
    /*  NewQueue
     *      should be empty
     *      raises not allowed exception on dequeue
     *      should be able to enqueue an item
     */
    /* Queue with one item
    *      should not be empty
    *      dequeue should return the item
    *      after dequeue
    *          should be empty
    */
    /* Queue with two items
    *      should not be empty
    *      dequeue should return first item enqueued
    *      after first dequeue
    *          queue should not be empty
    *          second dequeue should return second item enqueued
    *          after second dequeue
    *              queue should be empty
    */
    /*  Queue with three items
     *      dequeue should return first item enqueued
     *      after first dequeue
     *          dequeue should return second item enqueued
     *          after second dequeue
     *              dequeue should return third item enqueued
     *              after third dequeue
     *                  queue should be empty
     */
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void NewQueueShouldBeEmpty()
        {
            var queue = new Queue();
            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void NewQueueRaisesExceptionOnDequeue()
        {
            var queue = new Queue();
            try
            {
                queue.Dequeue();
                Assert.Fail("Expected an exception to have been raised");
            }
            catch (Exception e)
            {
                Assert.AreEqual(typeof(ActionNotAllowedException),e.GetType());
            }

        }

        [TestMethod]
        public void NewQueueShouldBeAbleToEnqueueItems()
        {
            var queue = new Queue();
            queue.Enqueue(1);
        }

        [TestMethod]
        public void AQueueWithOneItemShouldNotBeEmpty()
        {
            var queue = new Queue();
            queue.Enqueue(1);
            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod]
        public void AQueueWithOneItem_DequeueShouldReturnTheItem()
        {
            var queue = new Queue();
            queue.Enqueue(2);
            Assert.AreEqual(2, queue.Dequeue());
        }

        [TestMethod]
        public void AQueueWithOneItem_AfterDequeueItShouldBeEmpty()
        {
            var queue = new Queue();
            queue.Enqueue(2);
            queue.Dequeue();
            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void AQueueWithTwoItemsShouldNotBeEmpty()
        {
            var queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(4);
            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod]
        public void AQueueWithTwoItems_FirstDequeueShouldReturnFirstItemEnqueued()
        {
            var queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(4);
            Assert.AreEqual(3, queue.Dequeue());
        }

        [TestMethod]
        public void AQueueWithTwoItems_AfterFirstDequeue_ShouldNotBeEmpty()
        {
            var queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod]
        public void AQueueWithTwoItems_SecondDequeueShouldReturnSecondItemEnqueued()
        {
            var queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Dequeue();
            Assert.AreEqual(6, queue.Dequeue());
        }

        [TestMethod]
        public void AQueueWithTwoItems_AfterSecondDequeue_ShouldBeEmpty()
        {
            var queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Dequeue();
            queue.Dequeue();
            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void AQueueWithThreeItems_FirstDequeueShouldReturnFirstItemEnqueued()
        {
            var queue = new Queue();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            Assert.AreEqual(7, queue.Dequeue());
        }

        [TestMethod]
        public void AQueueWithThreeItem_SecondDequeueShouldReturnSecondItemEnqueued()
        {
            var queue = new Queue();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Dequeue();
            Assert.AreEqual(8,queue.Dequeue());
        }

        [TestMethod]
        public void AQueueWithThreeItems_ThirdDequeueShouldReturnThirdItemEnqueued()
        {
            var queue = new Queue();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Dequeue();
            queue.Dequeue();
            Assert.AreEqual(9, queue.Dequeue());
        }
    }
}
