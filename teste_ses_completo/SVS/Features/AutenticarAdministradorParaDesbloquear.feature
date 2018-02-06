Feature: Autenticação no sistema
Para acessar tela de escolha de módulo
Enquanto usuário
Eu gostaria de me autenticar no sistema e escolher o perfil

@autenticar_administrador

Scenario Outline: Autenticação com sucesso
	Given que estou na página de autenticacao do administrador 
	When eu preencho o campo CPF com o valor <cpfadministrador>
	And preencha o campo Senha com o valor <senhaadministrador>
	When clico no botão Entrar
	Then vejo na tela <mensagemadministrador>

	Examples: 
	| cpfadministrador | senhaadministrador | mensagemadministrador |
	| '11111111111'    | '1111111111'       | 'selecione o perfil'  | 
	