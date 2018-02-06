using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace teste_ses_completo
{
    [Binding]
    public class AutenticacaoNoSistemaSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"que estou na página de autenticacao do administrador")]
        public void GivenQueEstouNaPaginaDeAutenticacaoDoAdministrador()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080");
        }

        [When(@"eu preencho o campo CPF com o valor '(.*)'")]
        public void QuandoEuPreenchoOCampoCPFComOValor(string cpfadministrador)
        {
            IWebElement cpfadministradorTxt = driver.FindElement(By.Id("CPF"));
            cpfadministradorTxt.SendKeys(cpfadministrador);
        }

        [When(@"preencha o campo Senha com o valor '(.*)'")]
        public void QuandoPreenchaOCampoSenhaComOValor(string senhaadministrador)
        {
            IWebElement senhaadministradorTxt = driver.FindElement(By.Id("Senha"));
            senhaadministradorTxt.SendKeys(senhaadministrador);
        }

        [When(@"clico no botão Entrar")]
        public void QuandoClicoNoBotaoEntrar()
        {
            driver.FindElement(By.XPath("//*[@value='Entrar']")).Click();


        }

        [Then(@"vejo na tela (.*)")]
        public void ThenVejoNaTela(string mensagemadministrador)
        {
            bool achouTexto = driver.PageSource.Contains(mensagemadministrador);
            if (!achouTexto)
            {
                throw new Exception("Erro encontrado: \n" +
                    "CLASSE: AutenticacaoNoSistemaSteps\n" +
                    "MÉTODO: EntaoVejoNaTela.\n" +
                    "DESCRIÇÃO: Mensagem não exibida na tela: '" + mensagemadministrador + "'");
            }
        }
        public void FechaBrowser()
        {
            driver.Dispose();
        }
    }
}
