Feature: emitir Relatorio Usuario
	Para emitir relatório
	Enquanto usuário administrativo
	Eu de gerar relatorio de usuario

	

@emitir_relatorio_usuario
Scenario Outline: relatorio usuario
	Given que estou na pagina Imprimir Total acessos sistema
	And eu digito o periodo incicial<periodoincicial>
	And eu digito o periodo final<periodofinal>
	And eu digito o critério<criterio>
	And eu seleciono a ERS
	And eu seleciono o municipio
	When clico em filtrar
	

	Examples:

	| periodoincicial | periodofinal | criterio    |
	| 07/05/2011      | 12/01/2018   | 11111111111 |
