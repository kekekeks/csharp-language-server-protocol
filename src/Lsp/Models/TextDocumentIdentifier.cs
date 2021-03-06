﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OmniSharp.Extensions.LanguageServer.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class TextDocumentIdentifier
    {
        public TextDocumentIdentifier()
        {

        }

        public TextDocumentIdentifier(Uri uri)
        {
            Uri = uri;
        }
        /// <summary>
        /// The text document's URI.
        /// </summary>
        public Uri Uri { get; set; }
    }
}