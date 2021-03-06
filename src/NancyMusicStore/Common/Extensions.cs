﻿using System.Collections.Generic;
using Nancy;
using Microsoft.AspNetCore.Http.Authentication;
using Nancy.Owin;
using System;

namespace NancyMusicStore.Common
{
    public static class Extensions
    {
        public static string GetUserName(this Nancy.NancyContext context) => context.CurrentUser?.FindFirst(_ => _.Type == "name")?.Value;
       
    }
}