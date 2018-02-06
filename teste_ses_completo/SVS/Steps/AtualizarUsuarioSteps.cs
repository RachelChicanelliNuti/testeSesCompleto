using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace teste_ses_completo.SVS.Steps
{
    [Binding]
    public class AtualizarUsuarioSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"que estou na pagina de gestão de pessoas")]
        public void GivenQueEstouNaPaginaDeGestaoDePessoas()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/Usuario/Atualizar?pessoaId=33786");
        }       
        
        [When(@"eu digito o nome")]
        public void WhenEuDigitoONomeRachel(string nome)
        {
            IWebElement nomeTxt = driver.FindElement(By.Name("Nome"));
          
            nomeTxt.SendKeys(nome);
        }

        [Then(@"eu digito a data de nascimento(.*)")]
        public void ThenEuDigitoADataDeNascimento(string data)
        {
            IWebElement dataTxt = driver.FindElement(By.Id("DataNascimento"));
            dataTxt.SendKeys(data);

        }

        [Then(@"eu digito RG(.*)")]
        public void ThenEuDigitoRG(string rg)
        {
            IWebElement rgTxt = driver.FindElement(By.Id("RG"));
            rgTxt.SendKeys(rg);
        }

        [Then(@"eu digito o email(.*)")]
        public void ThenEuDigitoOEmail(string email)
        {
            IWebElement emailTxt = driver.FindElement(By.Id("EmailPrincipal"));
            emailTxt.SendKeys(email);
        }

        [Then(@"eu digito celular(.*)")]
        public void ThenEuDigitoCelular(string celular)
        {
            IWebElement celularTxt = driver.FindElement(By.Id("TelefoneCelular"));
            celularTxt.SendKeys(celular);
        }

        [Then(@"digito o logradouro(.*)")]
        public void ThenDigitoOLogradouro(string logradouro)
        {
            IWebElement logradouroTxt = driver.FindElement(By.Id("Logradouro"));
            logradouroTxt.SendKeys(logradouro);
        }

        [Then(@"eu digito o numero(.*)")]
        public void ThenEuDigitoONumero(string numero)
        {
            IWebElement numeroTxt = driver.FindElement(By.Id("Numero"));
            numeroTxt.SendKeys(numero);
        }

        [Then(@"eu digito o bairro(.*)")]
        public void ThenEuDigitoOBairro(string bairro)
        {
            IWebElement bairroTxt = driver.FindElement(By.Id("Bairro"));
            bairroTxt.SendKeys(bairro);
        }

        [Then(@"eu digito o complemento(.*)")]
        public void ThenEuDigitoOComplemento(string complemento)
        {
            IWebElement complementoTxt = driver.FindElement(By.Id("Complemento"));
            complementoTxt.SendKeys(complemento);
        }

        [Then(@"eu digito o CEP(.*)")]
        public void ThenEuDigitoOCEP(string cep)
        {
            IWebElement cepTxt = driver.FindElement(By.Id("CEP"));
            cepTxt.SendKeys(cep);
        }

        [Then(@"eu seleciono o estado(.*)")]
        public void ThenEuSelecionoOEstado(string estado)
        {
            var selectElement = new SelectElement(driver.FindElement(By.Id("estado")));
            selectElement.SelectByText("Mato Grosso");
            Thread.Sleep(2000);
        }

        [Then(@"eu seleciono o municipio(.*)")]
        public void ThenEuSelecionoOMunicipio(string municipio)
        {
            var selectElement = new SelectElement(driver.FindElement(By.Id("LocalidadeId")));
            selectElement.SelectByText("Alta Floresta");
            Thread.Sleep(2000);
        }
        [Then(@"clico em salvar(.*)")]
        public void ThenClicoEmSalvar()
        {
            driver.FindElement(By.XPath("//*[@value='Salvar']")).Click();
        }
    }
}
