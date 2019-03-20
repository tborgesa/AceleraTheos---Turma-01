﻿using System.Collections.Generic;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;

namespace UaiQueijos.Api.Config
{
    public class CustomDirectRouteProvider : DefaultDirectRouteProvider
    {
        protected override IReadOnlyList<IDirectRouteFactory> GetActionRouteFactories(HttpActionDescriptor actionDescriptor)
        {
            return actionDescriptor.GetCustomAttributes<IDirectRouteFactory>(true);
        }
    }
}