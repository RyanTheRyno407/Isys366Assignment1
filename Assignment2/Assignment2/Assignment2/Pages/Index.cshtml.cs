using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security;

namespace Assignment2.Pages
{
    [BindProperties(SupportsGet = true)]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public PersonModel? PersonModel { get; set; }
        public void OnGet()
        {
            _logger.LogError($"IndexOnGet");
            if (PersonModel != null)
            {
                _logger.LogError($"Index - OnGet - Name={PersonModel.Name}");
                _logger.LogError($"Index - OnGet - Name={PersonModel.Age}");
            }
        }

        public IActionResult OnPost()
        {
            _logger.LogError($"IndexOnPost");
            if (PersonModel != null)
            {
                _logger.LogError($"Index - OnPost - Name={PersonModel.Name}");
                _logger.LogError($"Index - OnPost - Name={PersonModel.Age}");
            }
            return RedirectToPagePreserveMethod("Privacy");
        }
    }
}
