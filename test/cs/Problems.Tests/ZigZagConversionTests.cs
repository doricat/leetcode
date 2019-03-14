using NUnit.Framework;

namespace Problems.Tests
{
    public class ZigZagConversionTests
    {
        [Test]
        public void ConvertTest1()
        {
            var result = ZigZagConversion.Convert("PAYPALISHIRING", 4);
            Assert.AreEqual(result, "PINALSIGYAHRPI");
        }
    }
}