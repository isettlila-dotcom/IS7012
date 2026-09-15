using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RecruitCatIsettlx.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Name");
            ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
            ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Name");
                ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
                ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Title");
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}