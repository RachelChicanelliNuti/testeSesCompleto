Feature: bloquear Usuario
	Para bloquear usuário
	Enquanto usuário administrativo
	Eu gostaria de gerar bloquar usuario

@bloquear_usuario
Scenario Outline: bloquear usuario
	Given eu estou na pagina gerencia de acesso
	And eu clico em bloquear
	And clico em cancelar
	And eu clico em bloquear novamente
	And eu digito a justificativa<justificativa>
	Then clico em salvar
	

	Examples: 

	| justificativa |
	| Teste         |
