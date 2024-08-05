using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using VeriCode.PageObjects;
using System.Drawing.Imaging;

namespace VeriCode
{
    public class TestInitialize : ElementExtensions
    {
       
       [SetUp]
        public void IniciarTeste()
        {
            //INICIAR DRIVER CHROME
            driver = new ChromeDriver();
            //NAVEGAR NA PAGINA 
            driver.Navigate().GoToUrl("https://sampleapp.tricentis.com/101/app.php");
            //MAXIMIZAR BROWSER
            driver.Manage().Window.Maximize();
            //ESPERA 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshotPath = "imagens.png";
           // screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png); 
           //ScreenshotImageFormat mesmo usando selenium.webdriver atualizado que inclui esse enum não é reconhecido

        }

        [TearDown]

        //FECHAR BROWSER DEPOIS DO TESTE CONCLUIDO
        public void FinalizarTeste()
        {
            if (driverQuit) driver.Quit();
        }

    }
}