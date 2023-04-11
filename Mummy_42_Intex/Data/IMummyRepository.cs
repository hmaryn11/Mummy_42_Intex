using Mummy_42_Intex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummy_42_Intex.Data
{
    public interface IMummyRepository
    {
        IQueryable<Artifacts> Artifacts { get; }
    }
}
