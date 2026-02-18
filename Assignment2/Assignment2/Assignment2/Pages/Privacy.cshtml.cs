using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Server.Kestrel.Transport.NamedPipes;
using System.ComponentModel;

namespace Assignment2.Pages
{
    [BindProperties(SupportsGet = true)]
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        
        public PersonModel? PersonModel { get; set; }

        public void OnGet()
        {
            _logger.LogError($"PrivacyOnGet");
            if (PersonModel != null)
            {
                _logger.LogError($"Privacy - OnGet - Name={PersonModel.Name}");
                _logger.LogError($"Privacy - OnGet - Name={PersonModel.Age}");
            }
        }

        public void OnPost()
        {
            _logger.LogError($"PrivacyOnPost");
            if (PersonModel != null)
            {
                _logger.LogError($"Privacy - OnPost - Name={PersonModel.Name}");
                _logger.LogError($"Privacy - OnPost - Name={PersonModel.Age}");
            }
        }
    }

}
