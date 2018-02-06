using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace teste_ses_completo
{
    [Binding]
    public class LiberarCadastroSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"que estou na página para liberar cadastro")]
        public void GivenQueEstouNaPaginaParaLiberarCadastro()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/SolicitacaoAcesso");
        }

        [Then(@"eu clico em usuario")]
        public void ThenEuClicoEmUsuario()
        {
            driver.FindElement(By.Id("Usuário")).Click();
        }

        [Then(@"eu clico em gerenciar")]
        public void ThenEuClicoEmGerenciar()
        {
            driver.FindElement(By.Id("SolicitacaoAcesso_Index")).Click();
        }

        [Then(@"eu clico em visualizar")]
        public void ThenEuClicoEmVisualizar()
        {
            IWebElement resu = driver.FindElement(By.ClassName("material-icons md-18"));
            IWebElement button = resu.FindElement(By.CssSelector("tbody > tr:nth-child(1) > td:nth-child(7) > a:nth-child(1)"));//ver como fazer
            button.Click();
        }

        [Then(@"eu seleciono a Descrição do perfil")]
        public void ThenEuSelecionoADescricaoDoPerfil(string perfil)
        {
            var selectElement = new SelectElement(driver.FindElement(By.Id("PerfilId")));
            selectElement.SelectByText("Gestor Estadual");
            Thread.Sleep(2000);

        }

        [Then(@"eu seleciono o status")]
        public void ThenEuSelecionoOStatus(string status)
        {
            var selectElement = new SelectElement(driver.FindElement(By.Id("Status")));
            selectElement.SelectByText("Aprovado");
            Thread.Sleep(2000);
        }

        [Then(@"eu digito o parecer(.*)")]
        public void ThenEuDigitoOParecer(string parecer)
        {
            IWebElement parecerTxt = driver.FindElement(By.Id("Parecer"));
            parecerTxt.SendKeys(parecer);
        }


        [Then(@"eu clico em salvar")]
        public void ThenEuClicoEmSalvar()
        {
            driver.FindElement(By.XPath("//*[@value='Salvar']")).Click();
        }
        public void FechaBrowser()
        {
            driver.Dispose();
        }
    }
}
