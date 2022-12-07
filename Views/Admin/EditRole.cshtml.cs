using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace dotnet.Views.Admin
{
    public class EditRole : PageModel
    {
        private readonly ILogger<EditRole> _logger;

        public EditRole(ILogger<EditRole> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}