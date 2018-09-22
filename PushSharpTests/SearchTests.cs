using Microsoft.VisualStudio.TestTools.UnitTesting;
using PushSharp.Search.Query;
using PushSharp.Search.Query.RedditParameters;
using PushSharp.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Tests
{
    [TestClass()]
    public class SearchTests
    {
        private const string NAME_VALUE_SEPARATOR = "=";

        [TestMethod]
        public void Given_MultiValueParameter_Expect_ParameterNameInOutput()
        {
            var output = GetMockMultiValueParameter();
            var outputString = output.ToString(NAME_VALUE_SEPARATOR);

            var startsWithName = outputString.StartsWith(output.Name + NAME_VALUE_SEPARATOR);

            Assert.IsTrue(startsWithName, $"'{output.Name}' not found in output string '{outputString}'");
        }

        [TestMethod]
        public void Given_MultiValueParameter_Expect_CommaSeparatedValues()
        {
            var output = GetMockMultiValueParameter();
            var outputString = output.ToString(NAME_VALUE_SEPARATOR);

            var referenceString = (output[0] + "," + output[1] + "," + output[2]);

            var hasCommaSeparatedValues = (outputString.Substring(outputString.IndexOf(NAME_VALUE_SEPARATOR) + 1) == referenceString);

            Assert.IsTrue(hasCommaSeparatedValues, $"'{outputString}' does not contain '{referenceString}'");
        }

        [TestMethod]
        public void Given_SearchQuery_Expect_NoUrlParameters()
        {
            var query = new MockSearchQuery("/MockQuery/search");
            var url = query.GetRequestUrl();

            Assert.IsFalse(url.Contains("?"), "Url should not contain '?'");
            Assert.IsFalse(url.Contains("&"), "Url should not contain '&'");
            Assert.IsFalse(url.Contains("="), "Url should not contain '='");
        }

        [TestMethod]
        public void Given_SearchQuery_Expect_WellFormedUrl()
        {
            var inputDateTime = new DateTime(2017, 01, 01);
            var inputAuthorName = "ExampleName";

            var query = new MockSearchQuery("/MockQuery/search");
            query.AfterDateTime = new AfterParameter(inputDateTime);
            query.Author = new AuthorParameter(inputAuthorName);

            var url = query.GetRequestUrl();

            Assert.IsFalse(url.Contains(" "), $"Url should not contain any spaces");
            Assert.IsTrue(url.Contains("&"), "Url should contain '&'");
            Assert.IsTrue(url.Contains("="), "Url should contain '='");
            Assert.IsTrue(url.Contains("?"), "Url should contain '?'");
            Assert.IsTrue(url.Contains(inputAuthorName), $"Url should contain '{inputAuthorName}'");
            Assert.IsTrue(url.Contains(inputDateTime.ToUnixEpoch().ToString()), $"Url should contain '{inputDateTime.ToUnixEpoch().ToString()}'");
        }

        private MockParameter GetMockMultiValueParameter()
        {
            var mockValue = new MockParameter(new[] { "testValueOne", "testValueTwo", "testValueThree" });

            return mockValue;
        }

        internal class MockSearchQuery : BaseRedditSearchQuery
        {
            public MockSearchQuery(string path) : base(path)
            {
            }
        }

        internal class MockParameter : MultiValueParameter<string>
        {
            public MockParameter(string[] values) : base("MockValue", values)
            {
            }
        }
    }
}