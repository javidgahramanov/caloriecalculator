using System.Linq;
using System.Text;
using System.Web.Mvc;
using CalorieCalculatorProyekt.Models.Concrete;
using CalorieCalculatorProyekt.Models.Interfaces;

namespace CalorieCalculatorProyekt.Controllers
{
    public class CalorieController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        // ninject injects dependency

        public CalorieController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("calculator/")]
        public ActionResult Index()
        {
            ViewData["categories"] = _unitOfWork.CategoryRepository.GetData();

            ViewData["foods"] = _unitOfWork.FoodProductRepository.GetData();

            return View();
        }


        [HttpPost]
        [Route("calculator/")]
        public ActionResult Index(FoodProduct foodProduct)
        {
            ViewData["categories"] = _unitOfWork.CategoryRepository.GetData();

            ViewData["foods"] = _unitOfWork.FoodProductRepository.GetData()
                .Where(x => x.CategoryId == foodProduct.CategoryId);

            return View();
        }


        [Route("calculator/daily")]
        public ActionResult DailyCalculator()
        {
            return View();
        }

        [Route("calculator/bmi")]
        public ActionResult BmiCalculator()
        {
            return View();
        }

        [Route("calculator/activities")]
        public ActionResult CalculatorByActivity()
        {
            var data = _unitOfWork.ActivityRepository.GetData();
            var count = data.Count();

            var activitiesJsStr = new StringBuilder();

            var i = 0;

            foreach (var item in data)
            {
                i++;
                activitiesJsStr.AppendFormat("{0}:{1}{2}", item.ActivityId, item.KkalMin, i != count ? "," : "");
            }

            ViewData["varJavaScriptActivities"] = activitiesJsStr.ToString();
            ViewData["activities"] = data;

            return View();
        }
    }
}