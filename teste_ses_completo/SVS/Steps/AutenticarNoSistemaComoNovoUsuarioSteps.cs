using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace teste_ses_completo.SVS.Steps
{
    [Binding]
    public class AutenticarNoSistemaComoNovoUsuarioSteps
    {
        private IWebDriver driver = new ChromeDriver();
       
        [When(@"eu preencho o campo CPF com o valor '(.*)'")]
        public void QuandoEuPreenchoOCampoCPFComOValor(string cpfnovousuario)
        {
            IWebElement cpfnovousuarioTxt = driver.FindElement(By.Id("CPF"));
            cpfnovousuarioTxt.SendKeys(cpfnovousuario);
        }

        [When(@"preencha o campo Senha com o valor '(.*)'")]
        public void QuandoPreenchaOCampoSenhaComOValor(string senhanovousuario)
        {
            IWebElement senhanovousuarioTxt = driver.FindElement(By.Id("Senha"));
            senhanovousuarioTxt.SendKeys(senhanovousuario);
        }

        [When(@"clico no botão Entrar")]
        public void QuandoClicoNoBotaoEntrar()
        {
            driver.FindElement(By.XPath("//*[@value='Entrar']")).Click();


        }

        [Then(@"vejo na tela (.*)")]
        public void ThenVejoNaTela(string mensagemnovousuario)
        {
            bool achouTexto = driver.PageSource.Contains(mensagemnovousuario);
            if (!achouTexto)
            {
                throw new Exception("Erro encontrado: \n" +
                    "CLASSE: AutenticacaoNoSistemaSteps\n" +
                    "MÉTODO: EntaoVejoNaTela.\n" +
                    "DESCRIÇÃO: Mensagem não exibida na tela: '" + mensagemnovousuario + "'");
            }
        }
    }
}
