﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data.StudentApp.Data;
using StudentApp.Models.StudentApp.Models;

namespace StudentApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentApp.Data.StudentApp.Data.ApplicationDbContext _context;

        public IndexModel(StudentApp.Data.StudentApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
