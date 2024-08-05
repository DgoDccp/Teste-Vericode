using OpenQA.Selenium;

namespace VeriCode
{
    public class ScreenshotHelper
    {
        private readonly IWebDriver _driver;
        private readonly string _screenshotsDirectory;

        public ScreenshotHelper(IWebDriver driver)
        {
            _driver = driver;

            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

            _screenshotsDirectory = Path.Combine(projectDirectory, "Screenshots");
        }

        //public void TakeScreenshot(string scenarioName)
        //{
        //    if (!Directory.Exists(_screenshotsDirectory))
        //    {
        //        Directory.CreateDirectory(_screenshotsDirectory);
        //    }

        //    string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        //    string screenshotFileName = $"{scenarioName}_{timestamp}.png";

        //    Screenshot screenshot = ((ITakesScreenshot)_driver).GetScreenshot();

        //    string screenshotFilePath = Path.Combine(_screenshotsDirectory, screenshotFileName);
        //    screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);

        //    Console.WriteLine($"Screenshot salvo em: {screenshotFilePath}");
        //}
    }
}