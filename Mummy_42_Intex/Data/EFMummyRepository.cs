using Mummy_42_Intex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummy_42_Intex.Data
{
    public class EFMummyRepository : IMummyRepository
    {
        private ArtifactContext _arContext { get; set; }
        public EFMummyRepository (ArtifactContext temp)
        {
            _arContext = temp;
        }
        public IQueryable<Artifacts> Artifacts => _arContext.Artifacts;
    }
}
