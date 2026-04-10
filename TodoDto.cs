namespace TodoServerBlaze
{

    public class TodoDTO (string? Content, bool IsChecked)
    {
        public string? Content { get; set; } = Content;
        public bool IsChecked { get; set; } = IsChecked;
    }
}
