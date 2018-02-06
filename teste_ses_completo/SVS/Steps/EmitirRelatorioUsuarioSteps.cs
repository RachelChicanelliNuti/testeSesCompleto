using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace teste_ses_completo
{
    [Binding]
    public class EmitirRelatorioUsuarioSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"que estou na pagina Imprimir Total acessos sistema")]
        public void GivenQueEstouNaPaginaImprimirTotalAcessosSistema()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/Usuario/ImprimirAcessoSistema");
        }

        [Then(@"eu digito o periodo incicial(.*)")]
        public void ThenEuDigitoOPeriodoIncicial(string periodoinicial)
        {
            IWebElement periodoinicialTxt = driver.FindElement(By.Id("DataInicial"));
            periodoinicialTxt.SendKeys(periodoinicial);
        }

        [Then(@"eu digito o periodo final(.*)")]
        public void ThenEuDigitoOPeriodoFinal(string periodofinal)
        {
            IWebElement periodofinalTxt = driver.FindElement(By.Id("DataFinal"));
            periodofinalTxt.SendKeys(periodofinal);
        }

        [Then(@"eu digito o critério(.*)")]
        public void ThenEuDigitoOCriterio(string criterio)
        {
            IWebElement criterioTxt = driver.FindElement(By.Id("NomeCpf"));
            criterioTxt.SendKeys(criterio);
        }

        [Then(@"eu seleciono a ERS")]
        public void ThenEuSelecionoAERS(string ers)
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle btn-default")));
            selectElement.SelectByText("Cuiabá");

            Thread.Sleep(2000);
        }

        [Then(@"eu seleciono o municipio")]
        public void ThenEuSelecionoOMunicipio()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle btn-default")));
            selectElement.SelectByText("Cuiabá");

            Thread.Sleep(2000);
        }
        [When(@"clico em filtrar")]
        public void WhenClicoEmFiltrar()
        {
            driver.FindElement(By.Id("btnFiltrar")).Click();
        }


        
    }
}
