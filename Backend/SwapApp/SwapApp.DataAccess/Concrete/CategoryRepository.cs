﻿using SwapApp.DataAccess.Abstract;
using SwapApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwapApp.DataAccess.Concrete
{
    public class CategoryRepository : GenericRepository<Category, SwapDbContext>, ICategoryRepository
    {
    }
}
