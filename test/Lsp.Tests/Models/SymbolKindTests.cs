using System;
using FluentAssertions;
using Newtonsoft.Json;
using OmniSharp.Extensions.LanguageServer.Models;
using Xunit;

namespace Lsp.Tests.Models
{
    public class SymbolKindTests
    {
        [Theory, JsonFixture]
        public void SimpleTest(string expected)
        {
            var model = new SymbolKind();
            var result = Fixture.SerializeObject(model);

            result.Should().Be(expected);

            var deresult = JsonConvert.DeserializeObject<SymbolKind>(expected);
            deresult.ShouldBeEquivalentTo(model);
        }
    }
}
