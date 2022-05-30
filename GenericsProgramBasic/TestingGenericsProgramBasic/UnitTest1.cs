namespace TestingGenericsProgramBasic
{
    public class Tests
    {

        [Test]
        public void GivenMaxInFirstPosition_TestMaximum_ReturnMaxInFirstPosition()
        {
            int[] arr = { 4, 8, 6, 3, 5 };
           GenericsProgramBasic.Generics<int> maxInteger = new GenericsProgramBasic.Generics<int>(arr);
            var Result = maxInteger.showMax();
            Assert.AreEqual(arr[4], Result);
        }
    } 
}
