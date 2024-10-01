using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using test_task.Models;
using test_task.Repositories;

namespace test_task.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private EFCursorPosRepository _repository;

        [BindProperty]
        public CursorData cursorData { get; set; }

        public IndexModel(ILogger<IndexModel> logger, EFCursorPosRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public void OnGet()
        {
            cursorData = new CursorData();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                CursorPos cursorPos = new CursorPos();
                string Data = JsonSerializer.Serialize(cursorData);
                cursorPos.id = Guid.NewGuid();
                cursorPos.data = Data;
                _repository.AddCursorPos(cursorPos);
            }
            return Page();
        }
    }
}
