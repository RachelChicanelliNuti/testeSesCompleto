Feature: atualizar Usuario
	Como administrador do sistema
	Eu quero atualizar o cadastro
	Para que o usuario possa acessar o sistema



@atualizar_usuario
Scenario Outline: Atualizar usuario
	Given que estou na pagina de gestão de pessoas	
	And eu digito o nome<nome>
	And eu digito a data de nascimento<data>
	And eu digito RG<rg>
	And eu digito o email<email>
	And eu digito celular<celular>
	And digito o logradouro<logradouro>
	And eu digito o numero<numero>
	And eu digito o bairro<bairro>
	And eu digito o complemento<complemento>
	And eu digito o CEP<cep>
	Then eu seleciono o estado  
	And eu seleciono o municipio
	Then clico em salvar

	Examples: 

	| cpf         | senha  | nome   | data     | rg           | email                 | celular     | logradouro | numero | bairro | complemento | cep       |
	| 98389338998 | 123456 | Rachel | 06041996 | 18.860.653-1 | rachel@mailinator.com | 88888888888 | Um         | 2      | Centro | 10          | 32223-250 |