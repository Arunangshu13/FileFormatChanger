
using FileFormatChanger.FormatChangers;
using System.Text;
using System.Diagnostics;
namespace TestFileFormatChange
{
    
    public class Tests
    {
        private Base8Formatter? formatter;

        [SetUp]
        public void Setup()
        {
            formatter = new Base8Formatter();
        }

        [Test]
        public void TestReadFileInBytes()
        {
            var filePath = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName + @"\Resources\TestData.txt";
            var data = formatter?.ReadFileInBytes(filePath);
            Assert.IsNotNull(data);
        }

        [Test]
        public void TestConvertDecimalToBase8Value()
        {

        }

        [Test]
        public void TesBase8Conversion()
        {
            var textData = Properties.Resources.TestData;
            var byteData = Encoding.ASCII.GetBytes(textData);
            foreach (byte value in byteData)
            {
                Debug.WriteLine();
            }
            Assert.Pass();
        }
    }
}