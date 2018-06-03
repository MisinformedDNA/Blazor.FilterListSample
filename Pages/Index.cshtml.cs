using Blazor.FilterListSample.Models;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.FilterListSample.Pages
{
    public class IndexModel : BlazorComponent
    {
        [Inject]
        protected HttpClient HttpClient { get; set; }

        public Media[] MediaList { get; set; } = new Media[0];
        public MediaType[] MediaTypes { get; set; }

        protected override async Task OnInitAsync()
        {
            MediaTypes = new MediaType[]
            {
                new MediaType("film", "Films"),
                new MediaType("novel", "Novels"),
                new MediaType("comic", "Comics"),
                new MediaType("videogame", "Video games"),
                new MediaType("promotional", "Promotional material"),
                new MediaType("tv", "Television"),
                new MediaType("short", "Short stories"),
                new MediaType("young", "Young readers books"),
                new MediaType("junior", "Junior novels"),
                new MediaType("unpublished", "Not yet released")
            };

            MediaList = await HttpClient.GetJsonAsync<Media[]>("media.json");
        }
    }
}
