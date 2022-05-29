namespace TestingGenericsProgramBasic
{
    public class Tests
    {
        [Test]
        public void GivenMaxFirstPosition_CheckMaxNum_ReturnMaxInFirstPosition()
        {
            int a = 5, b = 4, c = 3;
            GenericsProgramBasic.Generics<int> value = new GenericsProgramBasic.Generics<int>();
            var actualResult = value.MaximumOfIntegers(a, b, c);
            Assert.AreEqual(a, actualResult);

        }

        [Test]
        public void GivenMaxSecondPosition_CheckMaxNum_ReturnMax()
        {
            int a = 4, b = 5, c = 3;
            GenericsProgramBasic.Generics<int> value = new GenericsProgramBasic.Generics<int>();
            var actualResult = value.MaximumOfIntegers(a, b, c);
            Assert.AreEqual(b, actualResult);

        }
        [Test]
        public void GivenMaxThirdPosition_CheckMaxNum_ReturnMax()
        {
            int a = 3, b = 4, c = 5;
            GenericsProgramBasic.Generics<int> value = new GenericsProgramBasic.Generics<int>();
            var actualResult = value.MaximumOfIntegers(a, b, c);
            Assert.AreEqual(c, actualResult);

        }
      

    }
}
