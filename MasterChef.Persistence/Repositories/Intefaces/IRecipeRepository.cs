﻿using MasterChef.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChef.Persistence.Repositories.Intefaces
{
    public interface IRecipeRepository
    {
        public Task<List<Recipe>> List();
        public Task Save(Recipe entity);
        public Task Update(Recipe entity);
        public void Delete(int id);
       
    }
}
