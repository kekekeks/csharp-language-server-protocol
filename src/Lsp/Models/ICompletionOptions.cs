﻿namespace OmniSharp.Extensions.LanguageServer.Models
{
    public interface ICompletionOptions
    {
        bool ResolveProvider { get; set; }
        Container<string> TriggerCharacters { get; set; }
    }
}