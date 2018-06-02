namespace Blazor.FilterListSample.Models
{
    public class MediaType
    {
        public MediaType() { }

        public MediaType(string className, string displayName)
        {
            ClassName = className;
            DisplayName = displayName;
        }

        public string ClassName { get; set; }
        public string DisplayName { get; set; }
        public bool IsHidden { get; set; }
    }
}
