using eShopSolution.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ApiItergration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}
