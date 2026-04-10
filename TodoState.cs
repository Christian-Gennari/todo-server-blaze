public class TodoState
{
    public List<TodoDTO> Todos { get; set; } = [];

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();

    public void AddTodo(TodoDTO todo)
    {
        Todos.Add(todo);
        NotifyStateChanged();
    }

}
    
public class TodoDTO
{
    public string Content { get; set; } = string.Empty;
    public bool IsChecked { get; set; }
}