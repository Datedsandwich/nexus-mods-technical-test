using NUnit.Framework;

namespace Tests
{
    public class StarPrinterTest
    {
        private StarPrinter starPrinter;

        [SetUp]
        public void Setup()
        {
            starPrinter = new StarPrinter();
        }

        [Test]
        public void shouldPrintStars_loop()
        {
            string expectedOutput = "*****";

            using (var consoleOutput = new ConsoleOutputUtil())
            {
                starPrinter.PrintStarsLoop(5);

                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }

        [Test]
        public void shouldPrintStars_recursive()
        {
            string expectedOutput = "*****";

            using (var consoleOutput = new ConsoleOutputUtil())
            {
                starPrinter.PrintStarsRecursive(5);

                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }

        [Test]
        public void shouldPrintStars_linq()
        {
            string expectedOutput = "*****";

            using (var consoleOutput = new ConsoleOutputUtil())
            {
                starPrinter.PrintStarsLinq(5);

                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }

        [Test]
        public void shouldPrintStars_NoLoopsLinqsOrIfs()
        {
            string expectedOutput = "*****";

            using (var consoleOutput = new ConsoleOutputUtil())
            {
                starPrinter.PrintStarsOnlyString(5);

                Assert.AreEqual(expectedOutput, consoleOutput.GetOuput());
            }
        }
    }
}