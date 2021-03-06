﻿using System.Threading.Tasks;
using ASPNET.Fundamentals.DI.Autofac.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNET.Fundamentals.DI.Autofac.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICharacterRepository _characterRepository;

        public string CharacterName { get; set; }

        public IndexModel(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task OnGet()
        {
            CharacterName = await _characterRepository.GetCharacterName();
        }
    }
}
