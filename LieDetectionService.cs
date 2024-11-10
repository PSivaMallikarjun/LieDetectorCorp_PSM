namespace LieDetectorWebApp.Tests
{
    public class LieDetectionService
    {
        public bool IsDeceptive(double heartRate, double gsr)
        {
            // Example logic: If heart rate > 100 and GSR > 10, return true (deceptive)
            return heartRate > 100 && gsr > 10;
        }
    }
}