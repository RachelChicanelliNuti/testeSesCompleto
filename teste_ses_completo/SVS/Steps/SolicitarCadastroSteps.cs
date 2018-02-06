using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace teste_ses_completo.SVS.Steps
{
    [Binding]
    public class SolicitarCadastroSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"que estou na página de solicitacao de cadastro")]
        public void GivenQueEstouNaPaginaDeSolicitacaoDeCadastro()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"clico no botao de acesso")]
        public void GivenClicoNoBotaoDeAcesso()
        {
            driver.FindElement(By.Id("btnMenuAcesso")).Click();
        }
        
        [Given(@"clico em Solicitacao de acesso")]
        public void GivenClicoEmSolicitacaoDeAcesso()
        {
            driver.FindElement(By.Id("btnMenuSolicitacaoAcesso")).Click();
        }
        
        [Given(@"seleciono Tipo de Vinculo")]
        public void GivenSelecionoTipoDeVinculo()
        {
            var selectElement = new SelectElement(driver.FindElement(By.Name("-- Selecione --")));
            selectElement.SelectByText("Estatuário");

            Thread.Sleep(2000);
        }
        
        [Given(@"clico se eh Profissional de Saúde")]
        public void GivenClicoSeEhProfissionalDeSaude()
        {
            Console.Out.WriteLine("ProfissionalSaude%¨%*(&*(¨%¨#$%¨&%¨$&*%¨¨&*%");
            driver.FindElement(By.Name("Sim")).Click();
        }
        
        [Given(@"seleciono Classificação Brasileira de Ocupações")]
        public void GivenSelecionoClassificacaoBrasileiraDeOcupacoes()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectElement.SelectByText("223505 - Enfermeiro");

            Thread.Sleep(2000);
        }
        
        [Given(@"seleciono o Orgão")]
        public void GivenSelecionoOOrgao()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("dropdown - menu open")));
            selectElement.SelectByText("SECRETARIA DE ESTADO DE SAÚDE");

            Thread.Sleep(2000);
        }
        
        [Given(@"seleciono o Setor")]
        public void GivenSelecionoOSetor()
        {
            var selectElement = new SelectElement(driver.FindElement(By.Id("SetorId")));
            selectElement.SelectByText("Vigilância Sanitária");

            Thread.Sleep(2000);
        }
        
        [Given(@"preencho com o numero de matricula(.*)")]
        public void GivenPreenchoComONumeroDeMatricula(string matriculaSoli)
        {
            IWebElement matriculaSoliTxt = driver.FindElement(By.Id("Matricula"));
            matriculaSoliTxt.SendKeys(matriculaSoli);
        }
        
        [Given(@"seleciono Sistema")]
        public void GivenSelecionoSistema()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter - option pull - left")));
            selectElement.SelectByText("SVS - Vigilância Sanitária");

            Thread.Sleep(2000);
        }
        
        [Given(@"seleciono o Nivel de Abrangencia")]
        public void GivenSelecionoONivelDeAbrangencia()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("dropdown-menu open")));
            selectElement.SelectByText("Estadual");

            Thread.Sleep(2000);
        }
        
        [Given(@"escrevo Justificativa")]
        public void GivenEscrevoJustificativa(string justfivativaSoli)
        {
            IWebElement justfivativaSoliTxt = driver.FindElement(By.Id("Matricula"));
            justfivativaSoliTxt.SendKeys(justfivativaSoli);
        }
        
        [Then(@"clico no botao salvar")]
        public void ThenClicoNoBotaoSalvar()
        {
            driver.FindElement(By.ClassName("btn btn-primary")).Click();
        }
        [AfterScenario]
        public void FechaBrowser()
        {
            driver.Dispose();
        }
    }
    
}
