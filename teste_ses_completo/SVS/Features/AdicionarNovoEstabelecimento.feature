Feature: Adicionar Novo Estabelecimento 
	Como administrador do sistema
	Gostaria de acessar a página
	Para adicionar novo estabelecimento

@mytag
Scenario Outline: adicionar estabelecimento
	Given que estou na página adicionar estabelecimento 
	And clico em cancelar
	And entro na página adicionar estabelecimento 	
	And eu digito o nome fantasia<fantasia>
	And eu seleciono o tipo de estabelecimento
	And eu digito o cnpj<cnpj>
	And eu digito o CNES<cnes>
	And eu seleciono o CNAE
	And eu seleciono Albergado/Albergante
	And eu digito a inscricao municipal<municipal>
	And eu digito o numero do alvara<alvara>
	And eu digito o numero de funcionarios femininos<funcFeminino>
	And eu digito o numero de funcionarios masculino<funcMasculino>
	And eu digito o Horário de Funcionamento<horario>
	And eu digito Data Início Atividade<dataInicio>
	And eu digito a razao social<razao>
	And eu seleciono se isento de inscricao estadual
	And eu digito Inscrição Estadual<inscricao>
	And eu seleciono a Esfera Administrativa
	And seleciono o porte da empresa
	And eu seleciono Natureza da Organização
	And eu seleciono o tipo de cnpj
	And eu digito o logradouro<logradouro>
	And eu digito o numero<numero>
	And eu digito o CEP<cep>
	And eu digito o complemento<complemento>
	And eu seleciono municipio
	And eu seleciono o bairro
	And eu digito o telefone<telefone>
	And eu digito o celular<celular>
	And eu digito o email<email>
	And eu digito a observacao<observacao>
	And clico em continuar
	

	Examples: 

	| cpf            | senha  | fantasia              | cnpj           | cnes   | municipal | alvara | funcFeminino | funcMasculino | horario                         | dataInicio | razao                 | inscricao   | logradouro         | numero | cep      | complemento | telefone        | celular         | email                       | observacao      |
	| 956.960.193-07 | 123456 | Miha empresa de teste | 65617147000170 | 123456 | 123456    | 123456 | 3            | 4             | De segunda a sexta das 14 as 18 | 06/01/2011 | Miha empresa de teste | 55415856717 | Av. Getúlio Vargas | 222    | 78120617 | A           | (99) 99999-9999 | (99) 99999-9999 | minhaempresa@mailinator.com | Teste regressão |
