Feature: Autenticação no sistema
Para acessar tela de escolha de módulo
Enquanto usuário
Eu gostaria de me autenticar no sistema e escolher o perfil

@autenticar

Scenario Outline: Autenticação com sucesso
	Given que estou na página de autenticacao 
	When eu preencho o campo CPF com o valor <cpf>
	And preencha o campo Senha com o valor <senha>
	When clico no botão Entrar
	Then vejo na tela <mensagem>

	Examples: 
	| cpf           | senha        | mensagem             | 
	| '11111111111' | '1111111111' | 'selecione o perfil' | 
	| '22222222222' | '2222222222' | ''                   | 
	| '99999999999' | ''           | 'Senha obrigatório'  | 
	| ''            | '1111111111' | 'CPF obrigatório'    | 
