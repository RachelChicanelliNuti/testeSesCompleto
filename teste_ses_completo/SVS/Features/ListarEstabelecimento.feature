Feature: listar Estabelecimento
	Como administrador do sistema
	Gostaria de acessar a página de estabelecimento
	Para listar todos os estabelecimentos

@listar_estabelecimento
Scenario Outline: listar estabelecimento
	Given que eu estou na página de estabelecimento
	And eu clico em Filtros
	And eu digito o critério<criterio>
	And eu seleciono a sistuação
	And eu seleciono a natureza
	And eu seleciono o município
	And eu seleciono o bairro
	And eu seleciono o Tipo de Interesse
	And eu seleciono a esfera administrativa
	Then eu clico em  Filtrar
	

	Examples: 

	| criterio           |
	| 03.179.502/0001-10 |
