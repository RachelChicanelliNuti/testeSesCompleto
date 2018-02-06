using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace teste_ses_completo.SVS.Steps
{
    [Binding]
    public class AdicionarNotificacaoSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"que estou na pagina adicionar notificacao")]
        public void GivenQueEstouNaPaginaAdicionarNotificacao()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/Notificacao/Adicionar");
        }
        
        [Given(@"eu seleciono a abrangencia")]
        public void GivenEuSelecionoAAbrangencia()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectElement.SelectByText("Estadual");
            Thread.Sleep(2000);
        }
        
        [Given(@"eu seleciono o perfil de destino")]
        public void GivenEuSelecionoOPerfilDeDestino()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle btn-default")));
            selectElement.SelectByText("Técnico");
            Thread.Sleep(2000);
        }
        
        [Given(@"eu digito a data de expiração(.*)")]
        public void GivenEuDigitoADataDeExpiracao(string dataexpiracao)
        {
            IWebElement dataexpiracaoTxt = driver.FindElement(By.Id("DataExpiracao"));
            dataexpiracaoTxt.SendKeys(dataexpiracao);
        }
        
        [Given(@"eu digito o assunto")]
        public void GivenEuDigitoOAssunto(string assunto)
        {
            IWebElement assuntoTxt = driver.FindElement(By.Id("Assunto"));
            assuntoTxt.SendKeys(assunto);
        }
        
        [Given(@"eu digito a descrição da mensagem")]
        public void GivenEuDigitoADescricaoDaMensagemConfidencial(string descricaomensagem)
        {
            IWebElement descricaomensagemTxt = driver.FindElement(By.Id("Mensagem"));
            descricaomensagemTxt.SendKeys(descricaomensagem);
        }
        
        [When(@"eu clico em verificar destinatários")]
        public void WhenEuClicoEmVerificarDestinatarios()
        {
            driver.FindElement(By.ClassName("btn btn-primary")).Click(); 
        }
        
        [Then(@"eu clico em enviar")]
        public void ThenEuClicoEmEnviar()
        {
            driver.FindElement(By.ClassName("BtnEnviar")).Click();
        }
    }
}
