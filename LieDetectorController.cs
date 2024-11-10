using Microsoft.AspNetCore.Mvc;

namespace LieDetectorApp.Controllers
{
    public class LieDetectorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();  // Return the Index view to show the form
        }

        [HttpPost]
        public IActionResult SubmitData(int heartRate, int gsr)
        {
            // Simulate lie detection prediction logic
            string prediction = PredictLie(heartRate, gsr);

            // Pass the prediction result to the View
            ViewBag.Prediction = prediction;

            // Return the Prediction view, passing the result
            return View("Prediction");
        }

        private string PredictLie(int heartRate, int gsr)
        {
            // Simple threshold-based logic
            if (heartRate > 100 && gsr > 30)
            {
                return "Likely Lying";
            }
            else
            {
                return "Likely Truthful";
            }
        }

    }
}
