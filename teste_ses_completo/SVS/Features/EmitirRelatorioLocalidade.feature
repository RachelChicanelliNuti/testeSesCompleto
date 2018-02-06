Feature: emitir relatorio localidade
	como usuario administrador estadual
	eu gostaria de emitir relatorio 
	para saber dados das localidades

@emitir_relatorio_localidade
Scenario: emitir relatorio localidade
	Given que estou na tela SVS - Vigilância Sanitária
	And eu clico em relatório
	And eu clico em localidade
	And eu clico em município
	And seleciono o nome
	And clico em filtrar 
	And clico em fechar
	Given que estou na página Relatório Região Saúde
	And seleciono a Região de Saúde
	And clico em filtrar região
	Given que estou na tela Região Municipal Bairro
	And seleciono o Município
	And clico em filtrar municipio
	And clico em fechar municipio
	Given que estou na tela Endereço e Contato de Prefeitura, SMS e VISA
	And seleciono o tipo
	And seleciono o estado
	And seleciono o ERS
	And seleciono o município
	And clico em filtrar SMS e VISA
	And clico em fechar SMS e VISA
	Then clico em Limpar filtro

