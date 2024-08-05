
using OpenQA.Selenium;

namespace VeriCode.PageObjects
{
    class PageTricentis : TestInitialize
    {

        public void PreencherMake()
        {
            PreencherTexto("//*[@id= 'make']", "Audi");
        }
        public void PreencherModel()
        {
            PreencherTexto("//*[@id= 'model']", "Motorcycle");
        }
        public void PreencherCylinderCapacity()
        {
            PreencherTexto("//*[@id= 'cylindercapacity']", "2000");
        }
        public void PreencherEnginePerformance()
        {
            PreencherTexto("//*[@id= 'engineperformance']", "560");
        }

        public void PreencherDataOfManunfacture()
        {
            // Obter a data de hoje no formato MM/dd/yyyy
            string dataAtual = DateTime.Now.ToString("MM/dd/yyyy");
            // Preencher o campo de texto com a data de hoje
            PreencherTexto("//*[@id= 'dateofmanufacture']", dataAtual);
        }

        public void PreencherNumberOfSeats()
        {
            PreencherTexto("//*[@id= 'numberofseats']", "1");
        }
        public void ClicarRightHandDrive()
        {

            Clicar("//*[@id='insurance-form']/div/section/div[7]/p/label/span");

        }
        public void PreencherNumberOfSeatsMotorcycle()
        {
            PreencherTexto("//*[@id= 'numberofseatsmotorcycle']", "1");
        }
        public void PreencherFuelType()
        {
            PreencherTexto("//*[@id= 'fuel']", "Diesel");
        }
        public void PreencherPayload()
        {
            PreencherTexto("//*[@id= 'payload']", "200");
        }
        public void PreencherTotalWeight()
        {
            PreencherTexto("//*[@id= 'totalweight']", "2000");
        }

        public void PreencherListPrice()
        {
            PreencherTexto("//*[@id= 'listprice']", "50000");
        }
        public void PreencherLicensePlataNumber()
        {
            PreencherTexto("//*[@id= 'licenseplatenumber']", "2024");
        }
        public void PreencherAnnualMileage()
        {
            PreencherTexto("//*[@id= 'annualmileage']", "24000");
        }

        public void ClicarNext()
        {
            Clicar("//*[@id='nextenterinsurantdata']");
        }

        public void ValidaVehicleData()
        {
            // Valida se a seção de dados do veículo está visível e contém o texto esperado
            ValidarDados(By.XPath("//*[@id='entervehicledata']"), "Enter Vehicle Data");
        }

        public void ValidarEnterInsurantData()
        {
            // Valida se a seção de dados do segurado está visível e contém o texto esperado
            ValidarDados(By.XPath("//*[@id='enterinsurantdata']"), "Enter Insurant Data");
        }

        public void PreencherFirstName()
        {
            PreencherTexto("//*[@id= 'firstname']", "Teste");
        }

        public void PreencherLastName()
        {
            PreencherTexto("//*[@id= 'lastname']", "Teste");

        }
        public void PreencherDataNascimento()
        {
            PreencherTexto("//*[@id= 'birthdate']", "07/26/1987");
        }

        public void ClicarGender()
        {
            Clicar("//*[@id='insurance-form']/div/section[2]/div[4]/p/label/span");
        }

        public void PreencherStreetAddres()
        {
            PreencherTexto("//*[@id= 'streetaddress']", "Rua Saverio Quadrio");
        }
        public void PreencherCountry()
        {
            PreencherTexto("//*[@id= 'country']", "Brazil");
        }
        public void PreencherZipCode()
        {
            PreencherTexto("//*[@id= 'zipcode']", "05571190");
        }
        public void PreencherCity()
        {
            PreencherTexto("//*[@id= 'city']", "São Paulo");
        }
        public void PreencherOccupation()
        {
            PreencherTexto("//*[@id= 'occupation']", "Employee");
        }
        public void ClicarHobbies()
        {
            Clicar("//*[@id='insurance-form']/div/section[2]/div[10]/p/label/span");

        }
        public void PreencherWebSite()
        {
            PreencherTexto("//*[@id= 'website']", "https://sampleapp.tricentis.com/101/app.php");
        }
        public void ClicarOpen()
        {
            try
            {
                Clicar("//*[@id='open']");

                // CAMINHO COMPLETO DO ARQUIVO
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VeriCode.jpg");

                // ENCONTRAR ELEMENTO DO UPLOAD E ENVIAR CAMINHO DO ARQUIVO
                IWebElement uploadElement = driver.FindElement(By.XPath("//*[@id='open']"));
                uploadElement.SendKeys(filePath);


            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Elemento não encontrado: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
        public void ClicarNextInsurantData()
        {
            Clicar("//*[@id='nextenterproductdata']");

        }

    }
}



