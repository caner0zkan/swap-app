using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int id);

        void Create(Category entity);

        void Update(Category entity);

        void Delete(Category entity);
    }
}
