using AFP_UnitTest;

namespace StringManipulatorUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringReverseTest1()
        {
            StringManipulator s = new StringManipulator();
            string input = "cat";
            string expected = "tac";
            string actual = s.reverse(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StringReverseTest2()
        {
            StringManipulator s = new StringManipulator();
            string input = "a";
            string expected = "a";
            string actual = s.reverse(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StringReverseExceptionTest()
        {
            StringManipulator m = new StringManipulator();
            string input = null;
            Assert.Throws<ArgumentNullException>(() => m.reverse(input));
        }

        [TestCase("programming", 'g', 2)]
        [TestCase("csharp", 'x', 0)]
        [TestCase("a", 'a', 1)]
        public void StringCountOccurancesParameteriziedTest(string input, char target, int expected)
        {
            StringManipulator sm = new StringManipulator();
            //Assert.AreEqual(expected, sm.countOccurances(input,target));
            Assert.That(sm.countOccurances(input,target),Is.EqualTo(expected));
        }


    }
}