using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OmniSharp.Extensions.LanguageServer.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ReferenceContext
    {
        /// <summary>
        /// Include the declaration of the current symbol.
        /// </summary>
        public bool IncludeDeclaration { get; set; }
    }
}