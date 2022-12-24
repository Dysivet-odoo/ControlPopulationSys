using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Entities;
using DALL.Repositories.Interfaces;
using DALL.EF;

namespace DALL.Repositories.Impl
{
    public class StatisticRepository
        : BaseRepository<Statistics>, IStatisticRepository
    {
        internal StatisticRepository(StatsContext context) : base(context)
        {
        }
    }
}
