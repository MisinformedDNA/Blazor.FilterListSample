using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;

namespace Blazor.FilterListSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
