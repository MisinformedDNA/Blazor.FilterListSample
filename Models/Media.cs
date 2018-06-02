namespace Blazor.FilterListSample.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public bool IsPublished { get; set; }
        public int Order { get; set; }
        public string Year { get; set; }

        public bool IsChecked { get; set; }
    }
}
