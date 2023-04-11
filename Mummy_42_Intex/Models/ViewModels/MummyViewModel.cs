using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mummy_42_Intex.Models.ViewModels
{
    public class MummyViewModel
    {
        public IQueryable<Artifacts> Artifacts { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
