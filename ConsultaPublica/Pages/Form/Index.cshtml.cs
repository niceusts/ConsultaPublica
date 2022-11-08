﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsultaPublica.Data;
using RazorPagesMovie.Models;

namespace ConsultaPublica.Pages.Form
{
    public class IndexModel : PageModel
    {
        private readonly ConsultaPublica.Data.ConsultaPublicaContext _context;

        public IndexModel(ConsultaPublica.Data.ConsultaPublicaContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Genero.Contains(SearchString));
            }

            Movie = await movies.ToListAsync();
        }
    }
}
