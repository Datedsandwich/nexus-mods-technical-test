using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class DownloadsTest
    {
        private UnfinishedDownloads unfinishedDownloads;

        [SetUp]
        public void Setup()
        {
            unfinishedDownloads = new UnfinishedDownloads();
        }

        [Test]
        public void shouldReturnNamesOfUnfinishedDownloads()
        {
            var downloads = new Dictionary<string, Download>
            {
                { "A", new Download() { finished = true, name = "DownloadA.zip" } },
                { "B", new Download() { finished = false, name = "DownloadB.zip" } },
                { "C", new Download() { finished = false, name = "DownloadC.zip" } },
                { "D", new Download() { finished = true, name = "DownloadD.zip" } }
            };

            Assert.AreEqual("DownloadB.zip, DownloadC.zip", string.Join(", ", unfinishedDownloads.unfinished(downloads)));
        }
    }
}