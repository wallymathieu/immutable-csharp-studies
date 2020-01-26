
namespace Todos.Models
{
    public partial class TodoItem
    {
        public TodoItem WithId(decimal id){
            return new TodoItem(){ Id = id, Text = Text};
        }
        public TodoItem WithText(string text){
            return new TodoItem(){ Id = Id, Text = text};
        }
    }

}
