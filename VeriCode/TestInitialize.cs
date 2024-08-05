using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using VeriCode.PageObjects;

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

        }
       
    [TearDown]

        //FECHAR BROWSER DEPOIS DO TESTE CONCLUIDO
        public void FinalizarTeste()
        {
            if (driverQuit) driver.Quit();
        }

    }
}