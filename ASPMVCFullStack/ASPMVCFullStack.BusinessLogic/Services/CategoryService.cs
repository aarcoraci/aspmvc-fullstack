﻿using ASPMVCFullStack.BusinessLogic.Base;
using ASPMVCFullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPMVCFullStack.DataAccess;
using ASPMVCFullStack.DataAccess.Base;
using ASPMVCFullStack.DataAccess.Repositories;

namespace ASPMVCFullStack.BusinessLogic.Services
{
    public class CategoryService : BaseService<Category>
    {
        public CategoryService(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            Repository = new CategoryRepository(unitOfWork);
        }
    }
}