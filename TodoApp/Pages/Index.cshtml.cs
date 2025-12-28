using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace TodoApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> TodoItems { get; set; } = new List<string>();

        public void OnGet()
        {
            // Initialize or retrieve todo items from a data store
            TodoItems = new List<string> { "Sample Task 1", "Sample Task 2" };
        }

        public IActionResult OnPost(string todoItem)
        {
            if (!string.IsNullOrEmpty(todoItem))
            {
                TodoItems.Add(todoItem);
            }
            return RedirectToPage();
        }

        public IActionResult OnPostDelete(string item)
        {
            TodoItems.Remove(item);
            return RedirectToPage();
        }
    }
}