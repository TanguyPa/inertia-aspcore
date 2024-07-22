using System.Net;
using InertiaAspNetCore.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace InertiaAspNetCore.Utils;

public class LocationResult : IActionResult
{
    private readonly string _url;

    public LocationResult(string url) => _url = url;

    public async Task ExecuteResultAsync(ActionContext context)
    {
        if (context.IsInertiaRequest())
        {
            context.HttpContext.Response.Headers.Add("X-Inertia-Location", _url);
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Conflict;
        }

        await new RedirectResult(_url).ExecuteResultAsync(context);
    }
}
