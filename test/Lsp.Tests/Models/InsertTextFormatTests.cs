using System;
using FluentAssertions;
using Newtonsoft.Json;
using OmniSharp.Extensions.LanguageServer.Models;
using Xunit;

namespace Lsp.Tests.Models
{
    public class InsertTextFormatTests
    {
        [Theory, JsonFixture]
        public void SimpleTest(string expected)
        {
            var model = new InsertTextFormat();
            var result = Fixture.SerializeObject(model);

            result.Should().Be(expected);

            var deresult = JsonConvert.DeserializeObject<InsertTextFormat>(expected);
            deresult.ShouldBeEquivalentTo(model);
        }
    }
}
