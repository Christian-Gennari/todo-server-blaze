namespace TodoServerBlaze
{
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

    public void AddCheck(TodoDTO todo)
    {
        todo.IsChecked = true;
        NotifyStateChanged();
    }
    public void CreateNew()
    {
        var todo = new TodoDTO()
        {
            Content = "",
            IsChecked = false,
        };

        Todos.Add(todo);
        NotifyStateChanged();
    }

}
