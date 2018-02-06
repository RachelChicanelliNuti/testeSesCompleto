Feature: adicionar Notificacao
	como usuario administrador estadual
	eu gostaria de adicionar notificacao
	para enviar mensagem para os servidores

@adicionar_notificacao
Scenario Outline: adicionar notificacao
	Given que estou na pagina adicionar notificacao
	And eu seleciono a abrangencia
	And eu seleciono o perfil de destino
	And eu digito a data de expiração<dataexpiracao>
	And eu digito o assunto<assunto>
	And eu digito a descrição da mensagem<descricaomensagem>
	When eu clico em verificar destinatários
	Then eu clico em enviar

	Examples: 

	| dataexpiracao | assunto      | descricaomensagem |
	| 12/01/2017    | Confidencial | Confidencial      |