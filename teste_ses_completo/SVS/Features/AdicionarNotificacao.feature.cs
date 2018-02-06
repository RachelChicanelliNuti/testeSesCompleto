﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace teste_ses_completo.SVS.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("adicionar Notificacao")]
    public partial class AdicionarNotificacaoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AdicionarNotificacao.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "adicionar Notificacao", "\tcomo usuario administrador estadual\r\n\teu gostaria de adicionar notificacao\r\n\tpar" +
                    "a enviar mensagem para os servidores", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("adicionar notificacao")]
        [NUnit.Framework.CategoryAttribute("adicionar_notificacao")]
        [NUnit.Framework.TestCaseAttribute("12/01/2017", "Confidencial", "Confidencial", null)]
        public virtual void AdicionarNotificacao(string dataexpiracao, string assunto, string descricaomensagem, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "adicionar_notificacao"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("adicionar notificacao", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("que estou na pagina adicionar notificacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("eu seleciono a abrangencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("eu seleciono o perfil de destino", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("eu digito a data de expiração{0}", dataexpiracao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And(string.Format("eu digito o assunto{0}", assunto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And(string.Format("eu digito a descrição da mensagem{0}", descricaomensagem), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("eu clico em verificar destinatários", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("eu clico em enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion