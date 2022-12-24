using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Repositories.Interfaces;

namespace DALL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IStatisticRepository Statistics { get; }
        IHumanRepository Humans { get; }
        ILocalityRepository Localitys { get; }
        void Save();
    }
}
