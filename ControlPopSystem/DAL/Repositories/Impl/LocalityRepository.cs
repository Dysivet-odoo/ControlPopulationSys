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
    public class LocalityRepository
        : BaseRepository<Locality>, ILocalityRepository
    {
        internal LocalityRepository(StatsContext context) : base(context)
        { 
        }

    }
}
