using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace TodoApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> Todos { get; set; } = new List<string>();
        
        [BindProperty]
        public string NewTodo { get; set; } = string.Empty;

        public void OnGet()
        {
            // Initialize or load todos from a database or session
            Todos = new List<string> { "Sample Task 1", "Sample Task 2" };
        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(NewTodo))
            {
                Todos.Add(NewTodo);
            }
            return Page();
        }

        public IActionResult OnPostDelete(string todoToDelete)
        {
            Todos.Remove(todoToDelete);
            return Page();
        }
    }
}