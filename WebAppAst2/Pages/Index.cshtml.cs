using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAst2.Data;

namespace WebAppAst2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (name != null && description != null)
            {
                ResultSet = true;
            }

        }

        public void OnPost()
        {



        }
        [FromQuery(Name = "name")]

        public String name { get; set; }

        [FromQuery(Name = "description")]

        public String description { get; set; }

        public bool ResultSet { get; set; }
    }

}
