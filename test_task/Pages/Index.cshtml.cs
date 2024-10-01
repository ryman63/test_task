using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using test_task.Models;
using test_task.Repositories;

namespace test_task.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private EFCursorPosRepository _repository;

        [BindProperty]
        public CursorPos cursorPos { get; set; }

        public IndexModel(ILogger<IndexModel> logger, EFCursorPosRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public void OnGet()
        {
            cursorPos = new CursorPos();
            cursorPos.id = Guid.NewGuid();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                _repository.AddCursorPos(cursorPos);
            }
            return Page();
        }
    }
}
