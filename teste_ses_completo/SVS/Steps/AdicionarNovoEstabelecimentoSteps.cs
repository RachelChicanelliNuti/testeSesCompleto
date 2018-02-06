using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace teste_ses_completo
{
    [Binding]
    public class AdicionarNovoEstabelecimentoSteps
    {
        private IWebDriver driver = new ChromeDriver();
        [Given(@"que estou na página adicionar estabelecimento")]
        public void GivenQueEstouNaPaginaAdicionarEstabelecimento()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/Estabelecimento/Adicionar");
        }
        
        [Given(@"clico em cancelar")]
        public void GivenClicoEmCancelar()
        {
            driver.FindElement(By.ClassName("btn btn-warning")).Click();
        }
        
        [Given(@"entro na página adicionar estabelecimento")]
        public void GivenEntroNaPaginaAdicionarEstabelecimento()
        {
            driver.Navigate().GoToUrl("http://200.129.242.4:50080/Administracao/Estabelecimento/Adicionar");
        }

        [When(@"eu digito o nome fantasia(.*)")]
        public void WhenEuDigitoONomeFantasia(string fantasia)
        {
            IWebElement fantasiaTxt = driver.FindElement(By.Id("NomeFantasia"));
            fantasiaTxt.SendKeys(fantasia);
        }

        [When(@"eu seleciono o tipo de estabelecimento")]
        public void WhenEuSelecionoOTipoDeEstabelecimento()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle btn-default")));
            selectElement.SelectByText("Estabelecimentos de assistência médica, veterinária e odontológica geral e especializada. - até 50 leitos");
            Thread.Sleep(2000);
        }

        [When(@"eu digito o cnpj(.*)")]
        public void WhenEuDigitoOCnpj(string cnpj)
        {
            IWebElement cnpjTxt = driver.FindElement(By.Id("CNPJCPF"));
            cnpjTxt.SendKeys(cnpj);
        }

        [When(@"eu digito o CNES(.*)")]
        public void WhenEuDigitoOCNES(string cnes)
        {
            IWebElement cnesTxt = driver.FindElement(By.Id("CNES"));
            cnesTxt.SendKeys(cnes);
        }

        [When(@"eu seleciono o CNAE")]
        public void WhenEuSelecionoOCNAE()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectElement.SelectByText("4623-1/08 - Comércio atacadista de matérias-primas agrícolas com atividade de fracionamento e acondicionamento associada");
            Thread.Sleep(2000);
        }

        [When(@"eu seleciono Albergado/Albergante")]
        public void WhenEuSelecionoAlbergadoAlbergante()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectElement.SelectByText("Albergada");
            Thread.Sleep(2000);
        }

        [When(@"eu digito a inscricao municipal(.*)")]
        public void WhenEuDigitoAInscricaoMunicipal(string municipal)
        {
            IWebElement municipalTxt = driver.FindElement(By.Id("InscricaoMunicipal"));
            municipalTxt.SendKeys(municipal);
        }

        [When(@"eu digito o numero do alvara(.*)")]
        public void WhenEuDigitoONumeroDoAlvara(string alvara)
        {
            IWebElement alvaraTxt = driver.FindElement(By.Id("NumeroAlvara"));
            alvaraTxt.SendKeys(alvara);
        }

        [When(@"eu digito o numero de funcionarios femininos(.*)")]
        public void WhenEuDigitoONumeroDeFuncionariosFemininos(string funcFeminino)
        {
            IWebElement funcFemininoTxt = driver.FindElement(By.Id("NumeroFuncionariosFeminino"));
            funcFemininoTxt.SendKeys(funcFeminino);
        }

        [When(@"eu digito o numero de funcionarios masculino(.*)")]
        public void WhenEuDigitoONumeroDeFuncionariosMasculino(string funcMasculino)
        {
            IWebElement funcMasculinoTxt = driver.FindElement(By.Id("NumeroFuncionariosMasculino"));
            funcMasculinoTxt.SendKeys(funcMasculino);
        }

        [When(@"eu digito o Horário de Funcionamento(.*)")]
        public void WhenEuDigitoOHorarioDeFuncionamento(string horario)
        {
            IWebElement horarioTxt = driver.FindElement(By.Id("HorarioFuncionamento"));
            horarioTxt.SendKeys(horario);
        }

        [When(@"eu digito Data Início Atividade(.*)")]
        public void WhenEuDigitoDataInicioAtividade(string dataInicio)
        {
            IWebElement dataInicioTxt = driver.FindElement(By.Id("DataInicioAtividade"));
            dataInicioTxt.SendKeys(dataInicio);
        }

        [When(@"eu digito a razao social(.*)")]
        public void WhenEuDigitoARazaoSocial(string razao)
        {
            IWebElement razaoTxt = driver.FindElement(By.Id("RazaoSocial"));
            razaoTxt.SendKeys(razao);
        }

        [When(@"eu seleciono se isento de inscricao estadual")]
        public void WhenEuSelecionoSeIsentoDeInscricaoEstadual()
        {
            Console.Out.WriteLine("Isento Inscrição Estadual%¨%*(&*(¨%¨#$%¨&%¨$&*%¨¨&*%");
            driver.FindElement(By.Id("IsentoInscricaoEstadual")).Click();
        }

        [When(@"eu digito Inscrição Estadual(.*)")]
        public void WhenEuDigitoInscricaoEstadual(string inscricao)
        {
            IWebElement inscricaoTxt = driver.FindElement(By.Id("InscricaoEstadual"));
            inscricaoTxt.SendKeys(inscricao);
        }

        [When(@"eu seleciono a Esfera Administrativa")]
        public void WhenEuSelecionoAEsferaAdministrativa()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectElement.SelectByText("Estadual");

            Thread.Sleep(2000);
        }

        [When(@"seleciono o porte da empresa")]
        public void WhenSelecionoOPorteDaEmpresa()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectElement.SelectByText("Micro empresa");

            Thread.Sleep(2000);
        }

        [When(@"eu seleciono Natureza da Organização")]
        public void WhenEuSelecionoNaturezaDaOrganizacao()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("filter-option pull-left")));
            selectElement.SelectByText("Sindicato");

            Thread.Sleep(2000);
        }

        [When(@"eu seleciono o tipo de cnpj")]
        public void WhenEuSelecionoOTipoDeCnpj()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("caret")));
            selectElement.SelectByText("Mantenedora");

            Thread.Sleep(2000);
        }

        [When(@"eu digito o logradouro(.*)")]
        public void WhenEuDigitoOLogradouro(string logradouro)
        {
            IWebElement logradouroTxt = driver.FindElement(By.Id("Logradouro"));
            logradouroTxt.SendKeys(logradouro);
        }

        [When(@"eu digito o numero(.*)")]
        public void WhenEuDigitoONumero(string numero)
        {
            IWebElement numeroTxt = driver.FindElement(By.Id("Numero"));
            numeroTxt.SendKeys(numero);
        }

        [When(@"eu digito o CEP(.*)")]
        public void WhenEuDigitoOCEP(string cep)
        {
            IWebElement cepTxt = driver.FindElement(By.Id("CEP"));
            cepTxt.SendKeys(cep);
        }

        [When(@"eu digito o complemento(.*)")]
        public void WhenEuDigitoOComplemento(string complemento)
        {
            IWebElement complementoTxt = driver.FindElement(By.Id("Complemento"));
            complementoTxt.SendKeys(complemento);
        }

        [When(@"eu seleciono municipio")]
        public void WhenEuSelecionoMunicipio()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectElement.SelectByText("Água Boa");

            Thread.Sleep(2000);
        }

        [When(@"eu seleciono o bairro")]
        public void WhenEuSelecionoOBairro()
        {
            var selectElement = new SelectElement(driver.FindElement(By.ClassName("btn dropdown-toggle bs-placeholder btn-default")));
            selectElement.SelectByText("Centro");

            Thread.Sleep(2000);
        }

        [When(@"eu digito o telefone(.*)")]
        public void WhenEuDigitoOTelefone(string telefone)
        {
            IWebElement telefoneTxt = driver.FindElement(By.Id("Telefone"));
            telefoneTxt.SendKeys(telefone);
        }

        [When(@"eu digito o celular(.*)")]
        public void WhenEuDigitoOCelular(string celular)
        {
            IWebElement celularTxt = driver.FindElement(By.Id("Celular"));
            celularTxt.SendKeys(celular);
        }

        [When(@"eu digito o email(.*)")]
        public void WhenEuDigitoOEmail(string email)
        {
            IWebElement emailTxt = driver.FindElement(By.Id("Email"));
            emailTxt.SendKeys(email);
        }

        [When(@"eu digito a observacao(.*)")]
        public void WhenEuDigitoAObservacao(string observacao)
        {
            IWebElement observacaoTxt = driver.FindElement(By.Id("Observacao"));
            observacaoTxt.SendKeys(observacao);
        }

        [Given(@"clico em continuar")]
        public void GivenClicoEmContinuar()
        {
            driver.FindElement(By.ClassName("btn btn-primary")).Click();
        }
    }
}
