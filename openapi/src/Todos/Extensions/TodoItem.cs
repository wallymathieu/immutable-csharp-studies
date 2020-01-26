
namespace Todos.Models
{
    public partial class TodoItem
    {
        public TodoItem(decimal id,string text)
        {
            Id = id;
            Text = text;
        }
        public TodoItem WithId(decimal id){
            return new TodoItem(){ Id = id, Text = Text};
        }
        public TodoItem WithText(string text){
            return new TodoItem(){ Id = Id, Text = text};
        }
    }

}
