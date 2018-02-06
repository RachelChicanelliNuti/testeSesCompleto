using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace teste_ses_completo
{
    [Binding]
    public class BloquearUsuarioSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"eu estou na pagina gerencia de acesso")]
        public void GivenEuEstouNaPaginaGerenciaDeAcesso()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/SolicitacaoAcesso");
        }
        
        [Given(@"eu clico em bloquear")]
        public void GivenEuClicoEmBloquear()
        {
            IWebElement resu = driver.FindElement(By.ClassName("material-icons md-18"));
            IWebElement button = resu.FindElement(By.CssSelector("tbody > tr:nth-child(1) > td:nth-child(8) > a:nth-child(1)"));
            button.Click();
        }
        [Then(@"clico em cancelar")]
        public void ThenClicoEmCancelar()
        {
            driver.FindElement(By.Name("Cancelar")).Click();

        }
        [Given(@"eu clico em bloquear novamente")]
        public void GivenEuClicoEmBloquearNovamente()
        {
            IWebElement resu = driver.FindElement(By.ClassName("material-icons md-18"));
            IWebElement button = resu.FindElement(By.CssSelector("tbody > tr:nth-child(1) > td:nth-child(8) > a:nth-child(1)"));
            button.Click();
        }


        [Then(@"eu digito a justificativa(.*)")]
        public void ThenEuDigitoAJustificativa(string justificativa)
        {
            IWebElement justificativaTxt = driver.FindElement(By.Id("Justificativa"));
            justificativaTxt.SendKeys(justificativa);

        }

        
        [Then(@"clico em salvar")]
        public void ThenClicoEmSalvar()
        {
            driver.FindElement(By.ClassName("btn btn-primary")).Click();
        }
    }
}
