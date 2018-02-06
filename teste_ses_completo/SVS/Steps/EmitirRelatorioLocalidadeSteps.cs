using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace teste_ses_completo.SVS.Steps
{
    [Binding]
    public class EmitirRelatorioLocalidadeSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"que estou na tela SVS - Vigilância Sanitária")]
        public void GivenQueEstouNaTelaSVSVigilanciaSanitaria()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Login/Blank");
        }

        [Given(@"eu clico em relatório")]
        public void GivenEuClicoEmRelatorio()
        {
            driver.FindElement(By.Id("Relatório")).Click();
        }

        [Given(@"eu clico em localidade")]
        public void GivenEuClicoEmLocalidade()
        {
            driver.FindElement(By.Id("Localidade")).Click();
        }

        [Given(@"eu clico em município")]
        public void GivenEuClicoEmMunicipio()
        {
            driver.FindElement(By.Id("Municipio_ImprimirRelatorioERS")).Click();
        }

        [Given(@"seleciono o nome")]
        public void GivenSelecionoONome()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter-option pull-left")));
            selectElement.SelectByText("ERS Cuiabá");
            Thread.Sleep(2000);
        }

        [Given(@"clico em filtrar")]
        public void GivenClicoEmFiltrar()
        {
            driver.FindElement(By.Id("btnFiltrar")).Click();
        }

        [Given(@"clico em fechar")]
        public void GivenClicoEmFechar()
        {
            driver.FindElement(By.Id("ui-dialog-titlebar-close ui-dialog-button-close-ses-custom")).Click();
        }

        [Given(@"que estou na página Relatório Região Saúde")]
        public void GivenQueEstouNaPaginaRelatorioRegiaoSaude()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/Municipio/ImprimirRelatorioRegiaoSaude");
        }

        [Given(@"seleciono a Região de Saúde")]
        public void GivenSelecionoARegiaoDeSaude()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter-option pull-left")));
            selectElement.SelectByText("Cuiabá");
            Thread.Sleep(2000);
        }

        [Given(@"clico em filtrar região")]
        public void GivenClicoEmFiltrarRegiao()
        {
            driver.FindElement(By.Id("btnFiltrar")).Click();
        }

        [Given(@"clico em fechar região")]
        public void GivenClicoEmFecharRegiao()
        {
            driver.FindElement(By.Id("ui-dialog-titlebar-close ui-dialog-button-close-ses-custom")).Click();
        }

        [Given(@"que estou na tela Região Municipal Bairro")]
        public void GivenQueEstouNaTelaRegiaoMunicipalBairro()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/Municipio/ImprimirRelatorioRegiaoMunicipalBairro");
        }

        [Given(@"seleciono o Município")]
        public void GivenSelecionoOMunicipio()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter-option pull-left")));
            selectElement.SelectByText("Cuiabá");
            Thread.Sleep(2000);
        }

        [Given(@"clico em filtrar municipio")]
        public void GivenClicoEmFiltrarMunicipio()
        {
            driver.FindElement(By.Id("btnFiltrar")).Click();
        }

        [Given(@"clico em fechar municipio")]
        public void GivenClicoEmFecharMunicipio()
        {
            driver.FindElement(By.Id("ui-dialog-titlebar-close ui-dialog-button-close-ses-custom")).Click();
        }

        [Given(@"que estou na tela Endereço e Contato de Prefeitura, SMS e VISA")]
        public void GivenQueEstouNaTelaEnderecoEContatoDePrefeituraSMSEVISA()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/Municipio/ImprimirRelatorioMunicipioTipoEndereco");
        }

        [Given(@"seleciono o tipo")]
        public void GivenSelecionoOTipo()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter-option pull-left")));
            selectElement.SelectByText("VISA");
            Thread.Sleep(2000);
        }

        [Given(@"seleciono o estado")]
        public void GivenSelecionoOEstado()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter - option pull - left")));
            selectElement.SelectByText("Mato Grosso");
            Thread.Sleep(2000);
        }

        [Given(@"seleciono o ERS")]
        public void GivenSelecionoOERS()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter-option pull-left")));
            selectElement.SelectByText("ERS Cuiabá");
            Thread.Sleep(2000);
        }

        [Given(@"seleciono o município ERS")]
        public void GivenSelecionoOMunicipioERS()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter-option pull-left")));
            selectElement.SelectByText("Cuiabá");
            Thread.Sleep(2000);
        }

        [Given(@"clico em filtrar SMS e VISA")]
        public void GivenClicoEmFiltrarSMSEVISA()
        {
            driver.FindElement(By.Id("btnFiltrar")).Click();
        }

        [Given(@"clico em fechar SMS e VISA")]
        public void GivenClicoEmFecharSMSEVISA()
        {
            driver.FindElement(By.Id("ui-dialog-titlebar-close ui-dialog-button-close-ses-custom")).Click();
        }

        [Then(@"clico em Limpar filtro")]
        public void ThenClicoEmLimparFiltro()
        {
            driver.FindElement(By.Id("btnLimpar")).Click();
        }
    }
}
