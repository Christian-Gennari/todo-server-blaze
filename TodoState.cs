namespace TodoServerBlaze
{
    public class TodoState
    {
        public List<TodoDTO> Todos { get; set; } = [];

        public event Action? OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();

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
        public void RemoveTodo(TodoDTO todo)
        {
            Todos.Remove(todo);
            NotifyStateChanged();
        }

    }
}
