Feature: Autenticar no sistema como novo usuario
Para acessar tela de escolha de módulo
Enquanto usuário
Eu gostaria de me autenticar no sistema e escolher o perfil
#esse login será utilizado para testar todas as funcoes

@efetuar_login_novo_usuario

Scenario Outline: Autenticação com sucesso
	Given eu preencho o campo CPF com o valor <cpfnovousuario>
	And preencha o campo Senha com o valor <senhanovousuario>
	When clico no botão Entrar
	Then vejo na tela <mensagemnovousuario>

	Examples: 
	| cpfnovousuario | senhanovousuario | mensagemnovousuario |
	| '305806588-48' | '123456'         | 'Bem-vindo'         |
