﻿using System;
using FluentAssertions;
using Newtonsoft.Json;
using OmniSharp.Extensions.LanguageServer.Models;
using Xunit;

namespace Lsp.Tests.Models
{
    public class DidChangeWatchedFilesParamsTests
    {
        [Theory, JsonFixture]
        public void SimpleTest(string expected)
        {
            var model = new DidChangeWatchedFilesParams() {
                Changes = new[] {
                    new FileEvent() {
                        Type = FileChangeType.Created,
                        Uri = new Uri("file:///someawesomefile")
                    }
                }
            };
            var result = Fixture.SerializeObject(model);

            result.Should().Be(expected);

            var deresult = JsonConvert.DeserializeObject<DidChangeWatchedFilesParams>(expected);
            deresult.ShouldBeEquivalentTo(model);
        }
    }
}
