﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OmniSharp.Extensions.LanguageServer.Capabilities.Server;

namespace OmniSharp.Extensions.LanguageServer.Converters
{
    class TextDocumentSyncConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var v = value as TextDocumentSync;

            if (v.HasOptions)
            {
                serializer.Serialize(writer, v.Options);
            }
            else if (v.HasKind)
            {
                new JValue(v.Value).WriteTo(writer);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Integer)
            {
                return new TextDocumentSync((TextDocumentSyncKind)Convert.ToInt32(reader.Value));
            }

            return new TextDocumentSync(JObject.Load(reader).ToObject<TextDocumentSyncOptions>());
        }

        public override bool CanRead => true;

        public override bool CanConvert(Type objectType) => objectType == typeof(TextDocumentSync);
    }
}