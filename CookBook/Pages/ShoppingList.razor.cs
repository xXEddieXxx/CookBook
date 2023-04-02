using Microsoft.AspNetCore.Components.Web;
using CookBook.Data;

namespace CookBook.Pages
{
    public partial class ShoppingList
    {
        private List<ShoppingListItem> _items = new();
        private string _newItem;

        private void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(_newItem))
            {
                _items.Add(new ShoppingListItem { Title = _newItem });
                _newItem = string.Empty;
            }
        }
        private void HandleKeyDown(KeyboardEventArgs e)
        {
            if (e.Key == "Enter" || e.Code == "NumpadEnter")
            {
                AddTodo();
            }
        }

        private void Delete(ShoppingListItem current)
        {
            _items.Remove(current);
        }

        private async void DeleteAll()
        {
            var answer = await DialogService.DisplayConfirm("Confirmation", "Do you want to delete all Items", "Yes", "No");
            if (answer) 
            {
                _items.Clear();
            }
        }
    }
}
