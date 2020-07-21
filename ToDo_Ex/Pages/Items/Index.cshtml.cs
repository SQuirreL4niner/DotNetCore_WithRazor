using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDo_Ex.Data;
using ToDo_Ex.Models;

namespace ToDo_Ex.Pages_Items
{
    public class IndexModel : PageModel
    {
        private readonly ToDo_Ex.Data.ItemsContext _context;

        public IndexModel(ToDo_Ex.Data.ItemsContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
