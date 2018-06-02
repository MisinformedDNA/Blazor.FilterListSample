using Blazor.FilterListSample.Models;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System.IO;

namespace Blazor.FilterListSample.Pages
{
    public class IndexModel : BlazorComponent
    {
        public Media[] MediaList { get; set; }
        public MediaType[] MediaTypes { get; set; }

        protected override void OnInit()
        {
            var json = File.ReadAllText("media.json");
            MediaList = JsonUtil.Deserialize<Media[]>(json);

            MediaType[] DefaultMediaTypes = new MediaType[]
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
        }
    }
}
