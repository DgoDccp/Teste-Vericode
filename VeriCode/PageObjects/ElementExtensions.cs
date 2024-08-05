using OpenQA.Selenium;

namespace VeriCode.PageObjects
{
    public class ElementExtensions : GlobalVariables
    {

        public void PreencherTexto(string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }
        public void Clicar(string xpath)
        {
           
            
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public void ValidarDados(By locator, string expectedValue)
        {
            try
            {
                // Encontrar o elemento pelo localizador fornecido
                IWebElement element = driver.FindElement(locator);

                // Obter o texto do elemento encontrado
                string actualValue = element.Text;

                // Verificar se o texto do elemento contém o valor esperado
                Assert.That(actualValue, Does.Contain(expectedValue),
                    $"O texto do elemento localizado por '{locator}' não contém o valor esperado. Valor encontrado: '{actualValue}'");

            }
            catch (NoSuchElementException ex)
            {
                Assert.Fail($"Elemento não encontrado: {ex.Message}");
            }
            catch (Exception ex)
            {
                Assert.Fail($"Erro ao validar dados: {ex.Message}");
            }
        }



    }
}
   