namespace TodoServerBlaze
{

    public class TodoDTO(string? content, bool isChecked)
    {
        public string? Content { get; set; } = content;
        public bool IsChecked { get; set; } = isChecked;
    }
}
