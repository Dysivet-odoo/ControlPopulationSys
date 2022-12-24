using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PopControl.DAL.Entities;
using PopControl.DAL.Repositories.Impl;
using Microsoft.EntityFrameWorkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Tests
{
    public class TestStatsRepository
        : BaseRepository<Statistics>
    {
        public TestStatsRepository(DbContext context) 
            : base(context)
        {
        }
    }
}
