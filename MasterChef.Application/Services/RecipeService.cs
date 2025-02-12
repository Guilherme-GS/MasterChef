﻿using MasterChef.Application.Interfaces;
using MasterChef.Domain;
using MasterChef.Domain.Models;
using MasterChef.Persistence.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef.Application.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public void Create(Recipe recipe)
        {
            _recipeRepository.Save(recipe);
        }

        public void Delete(int id)
        {
            _recipeRepository.Delete(id);
        }

        public void Update(Recipe recipe)
        {
            _recipeRepository.Update(recipe);
        }

        public async Task<List<Recipe>> List()
        {
            return await _recipeRepository.List();
        }

        public async Task<List<Recipe>> List(int IdCategory)
        {
            var retorno = await _recipeRepository.List();
            return retorno.Where(r => r.IdCategory == IdCategory).ToList();
        }

        public async Task<List<Recipe>> List(string Chef)
        {
            var retorno = await _recipeRepository.List();
            return retorno.Where(r => r.Chef == Chef).ToList();
        }

        public Task<Recipe> Get(int id)
        {
            return _recipeRepository.Get(id);
        }
    }
}
