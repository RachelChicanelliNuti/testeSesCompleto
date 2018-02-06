Feature: liberar Cadastro
	Como administrador do sistema
	Gostaria de acessar a página
	Para que eu liberar o cadastro de usuário

@liberar_cadastro
Scenario Outline: liberar cadastro
	Given que estou na página para liberar cadastro 
	And eu clico em usuario
	And eu clico em gerenciar
	And eu clico em visualizar
	And eu seleciono a Descrição do perfil
	And eu seleciono o status
	And eu digito o parecer<parecer>
	Then eu clico em salvar

	Examples: 
	| parecer            |
	| Solicitacao aceita |
