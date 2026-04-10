using ovningsuppgift_todo_app_blazor_server;
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

}

// public class TodoDTO(string? content, bool isChecked)
// {
//     public string? Content { get; set; } = content;
//     public bool IsChecked { get; set; } = isChecked;
// }
