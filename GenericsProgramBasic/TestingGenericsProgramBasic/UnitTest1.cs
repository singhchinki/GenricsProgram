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
    }
}