﻿using Phony.Kernel.Repositories;
using Phony.Model;

namespace Phony.Persistence.Repositories
{
    public class CompanyMoveRepo : Repository<CompanyMove>, ICompanyMoveRepo
    {
        public CompanyMoveRepo(PhonyDbContext context) : base(context)
        {
        }

        public PhonyDbContext PhonyDbContext
        {
            get { return Context as PhonyDbContext; }
        }
    }
}