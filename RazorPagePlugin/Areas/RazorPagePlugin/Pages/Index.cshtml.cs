using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagePlugin.MyFeature.Pages
{
    public class RazorPagesPluginPage : PageModel
    {

        public string Text { get; set; } = "WOOHOOO";
        public void OnGet()
        {

        }
    }
}