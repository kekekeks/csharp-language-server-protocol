﻿using System;
using System.Threading.Tasks;
using OmniSharp.Extensions.LanguageServer;
using OmniSharp.Extensions.LanguageServer.Models;

// ReSharper disable CheckNamespace

namespace OmniSharp.Extensions.LanguageServer.Protocol
{
    public static class RegisterCapabilityExtensions
    {
        public static async Task RegisterCapability(this ILanguageServer mediator,  RegistrationParams @params)
        {
            try
            {
                await mediator.SendRequest("client/registerCapability", @params);
            }
            catch (Exception e)
            {
                // VsCode today does not implement LSP properly.
                await mediator.SendRequest("client/registerFeature", @params);
            }
        }
    }
}
