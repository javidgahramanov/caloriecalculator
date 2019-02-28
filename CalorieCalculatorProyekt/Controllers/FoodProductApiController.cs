using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

using CalorieCalculatorProyekt.Models.Concrete;
using CalorieCalculatorProyekt.Models.Concrete.Repositories;
using CalorieCalculatorProyekt.Models.Interfaces;

namespace CalorieCalculatorProyekt.Controllers
{
    public class FoodProductRequestDto
    {
        public int CategoryId { get; set; }
        public int Id { get; set; }
    }

    public class FoodProductController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public FoodProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpPost]
        public IEnumerable<FoodProduct> Get(FoodProductRequestDto model)
        {
            return _unitOfWork.FoodProductRepository.GetData().Where(x => x.CategoryId == model.CategoryId);
        }

        [HttpPost]
        public FoodProduct GetProductDetail(FoodProductRequestDto model)
        {
            return _unitOfWork.FoodProductRepository.GetData(model.Id);
        }
    }
}
