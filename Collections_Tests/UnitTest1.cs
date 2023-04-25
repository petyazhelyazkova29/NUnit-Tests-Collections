using Collections;

namespace Collections_Tests_NUnit
{
    public class Collections_Tests
    {

        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            var nums = new Collection<int>();
            Assert.That(nums.ToString(), Is.EqualTo("[]"));
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            var nums = new Collection<int>(2);
            Assert.That(nums[0], Is.EqualTo(2));
        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            var nums = new Collection<int>(3, 5, 7);
            Assert.That(nums.ToString(), Is.EqualTo("[3, 5, 7]"));
        }

        [Test]

        public void Test_Collections_AddNumberToEmptyCollection()
        {
            var nums = new Collection<int>();
            nums.Add(1);
            nums.Add(2);
            Assert.That(nums.ToString(), Is.EqualTo("[1, 2]"));
        }

        [Test]
        public void Test_Collections_AddNumberToCollection()
        {
            var nums = new Collection<int>(1, 2);
            nums.Add(3);

            Assert.That(nums.ToString(), Is.EqualTo("[1, 2, 3]"));
        }

        [Test]
        public void Test_Collections_AddNumberToFullCollection()
        {
            var nums = new Collection<int>(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            nums.Add(17);

            Assert.That(nums.ToString(), Is.EqualTo("[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17]"));
        }

        [Test]
        public void Test_Collection_GetIntegerByIndex()
        {
            var nums = new Collection<int>(8, 9, 10);

            Assert.That(nums[0], Is.EqualTo(8));
            Assert.That(nums[1], Is.EqualTo(9));
            Assert.That(nums[2], Is.EqualTo(10));
        }

        [Test]
        public void Test_Collection_GetStringByIndex()
        {
            var cars = new Collection<string>("BMW", "Volvo");
            var item0 = cars[0];
            var item1 = cars[1];
            Assert.That(item0, Is.EqualTo("BMW"));
            Assert.That(item1, Is.EqualTo("Volvo"));
        }

        [Test]
        public void Test_Collection_GetByInvalidIndex()
        {
            var nums = new Collection<double>(0.1, 0.2, 0.3);
            Assert.That(() => { var number = nums[4]; },
              Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var number = nums[-8]; },
              Throws.InstanceOf<ArgumentOutOfRangeException>());
            Assert.That(() => { var number = nums[9000]; },
              Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Test_Collection_ToStringNestedCollections()
        {
            var names = new Collection<string>("Petya", "Ivelina", "Raina");
            var ages = new Collection<int>(29, 30, 31);
            var nested = new Collection<object>(names, ages);
            string nestedToString = nested.ToString();
            Assert.That(nestedToString,
              Is.EqualTo("[[Petya, Ivelina, Raina], [29, 30, 31]]"));
        }

        [Test]
        public void Test_Collection_Clear()
        {
            var nums = new Collection<int>(3);
            nums.Clear();

            Assert.That(nums.ToString, Is.EqualTo("[]"));
        }

        [Test]
        public void Test_Collection_InsertAtEnd()
        {
            var nums = new Collection<int>(1, 3);
            nums.InsertAt(2, 5);
            Assert.That(nums.ToString, Is.EqualTo("[1, 3, 5]"));
        }

        [Test]
        public void Test_Collection_InsertAtStart()
        {
            var nums = new Collection<int>(1, 3);
            nums.InsertAt(0, -1);
            Assert.That(nums.ToString, Is.EqualTo("[-1, 1, 3]"));
        }


        [Test]
        public void Test_Collection_InsertAtMiddle()
        {
            var nums = new Collection<int>(1, 3, 5);
            nums.InsertAt(2, 100);
            Assert.That(nums.ToString, Is.EqualTo("[1, 3, 100, 5]"));
        }

        [Test]
        public void Test_Collection_RemoveAtStart()
        {
            var nums = new Collection<int>(2, 4, 6, 8);
            nums.RemoveAt(0);
            Assert.That(nums.ToString, Is.EqualTo("[4, 6, 8]"));
        }

        [Test]
        public void Test_Collection_RemoveAtEnd()
        {
            var nums = new Collection<int>(2, 4, 6, 8);
            nums.RemoveAt(3);
            Assert.That(nums.ToString, Is.EqualTo("[2, 4, 6]"));
        }

        [Test]
        public void Test_Collection_RemoveAtMiddle()
        {
            var nums = new Collection<int>(2, 4, 6, 8);
            nums.RemoveAt(2);
            Assert.That(nums.ToString, Is.EqualTo("[2, 4, 8]"));
        }

        [Test]
        public void Test_Collection_ExchangeFirstLast()
        {
            var nums = new Collection<int>(2, 4, 6);
            nums.Exchange(0,2);
            Assert.That(nums.ToString, Is.EqualTo("[6, 4, 2]"));
        }

        [Test]
        public void Test_Collection_ExchangeMiddle()
        {
            var nums = new Collection<int>(2, 4, 6);
            nums.Exchange(0, 1);
            Assert.That(nums.ToString, Is.EqualTo("[4, 2, 6]"));
        }      
    }
}