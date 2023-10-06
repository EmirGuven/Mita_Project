﻿using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
    public class BranchType_Repository : BaseRepository<BranchType> , IBranchType_Repository
    {
        public BranchType_Repository(MyContext db) : base(db)
        {
            
        }
    }
}
