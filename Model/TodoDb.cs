using Microsoft.EntityFrameworkCore;

namespace FloressenciaCrud.Model
{
    public class TodoDb
    {
        public TodoDb(DbContextOptions<TodoDb> options)
       : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
