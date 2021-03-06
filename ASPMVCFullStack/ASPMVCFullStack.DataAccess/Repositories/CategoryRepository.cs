﻿using ASPMVCFullStack.DataAccess.Base;
using ASPMVCFullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCFullStack.DataAccess.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
