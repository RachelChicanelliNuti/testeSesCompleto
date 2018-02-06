Feature: solicitar Cadastro
	Como usuario do sistema
	Eu quero solicitar a liberacao
	Para que eu possa acessar o sistema

@solicitarCadastro
Scenario Outline: solicitacao com sucesso
	Given que estou na página de solicitacao de cadastro	
	And clico no botao de acesso
	And clico em Solicitacao de acesso
	And seleciono Tipo de Vinculo
	And clico se eh Profissional de Saúde
	And seleciono Classificação Brasileira de Ocupações
	And seleciono o Orgão
	And seleciono o Setor
	And preencho com o numero de matricula <matriculaSoli>
	And seleciono Sistema
	And seleciono o Nivel de Abrangencia
	And escrevo Justificativa<justfivativaSoli>
	Then clico no botao salvar

	Examples: 
	| matriculaSoli   | justfivativaSoli   |
	| 067.532.680.357 | Para fins de Teste |
