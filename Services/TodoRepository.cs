using System.Collections.Generic;
using Todo.Api.Models;

namespace Todo.Api.Services
{
    public class TodoRepository : ITodoRepository
    {
            private List<TodoItem> _items = new List<TodoItem>()
            {
                    new TodoItem{ Id = 1, Action="Thing one.", IsDone=true},
                    new TodoItem{ Id = 2, Action="Thing two.", IsDone=false},
            };

            private IEnumerable<TodoItem> GetAllTodoItems()
            {
                return _items;
            }

        IEnumerable<TodoItem> ITodoRepository.GetAllTodoItems()
        {
            throw new System.NotImplementedException();
        }
    }

}