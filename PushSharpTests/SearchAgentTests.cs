using Microsoft.VisualStudio.TestTools.UnitTesting;
using PushSharp.Search.Query;
using PushSharp.Web;
using PushSharpTests.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Tests
{
    [TestClass]
    public class SearchAgentTests
    {
        [TestMethod]
        public void Given_SearchQuery_Expect_SingleCommentResult()
        {
            var searchAgent = new RedditSearchAgent(new MockHttpContentDownloader());

            var comments = searchAgent.SearchComments(new CommentSearchQuery());

            Assert.IsTrue(comments.HasValue, $"{nameof(comments)} has value");
            Assert.AreEqual(1, comments.ValueList.Count, nameof(comments));
        }

        [TestMethod]
        public void Given_SearchQuery_Expect_SingleSubmissionResult()
        {
            var searchAgent = new RedditSearchAgent(new MockHttpContentDownloader());

            var submissions = searchAgent.SearchSubmissions(new SubmissionSearchQuery());

            Assert.IsTrue(submissions.HasValue, $"{nameof(submissions)} has value");
            Assert.AreEqual(1, submissions.ValueList.Count, nameof(submissions));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Given_NullSearchQuery_Expect_Exception()
        {
            var searchAgent = new RedditSearchAgent(new MockHttpContentDownloader());

            var submissions = searchAgent.SearchSubmissions(null);
        }
    }

    internal class MockHttpContentDownloader : IRetrieveHttpContent
    {
        public byte[] GetUrlContent(string url)
        {
            if (url.Contains(CommentSearchQuery.RELATIVE_URL_PART))
            {
                return Encoding.UTF8.GetBytes(Resources.CommentJson);
            }

            if (url.Contains(SubmissionSearchQuery.RELATIVE_URL_PART))
            {
                return Encoding.UTF8.GetBytes(Resources.SubmissionJson);
            }

            throw new NotSupportedException($"'{url}' is not a supported value");
        }
    }
}
