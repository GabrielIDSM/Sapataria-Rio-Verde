# Sapataria Rio Verde (Software de Gestão)

![Imagem Principal](https://github.com/GabrielIDSM/Sapataria-Rio-Verde/blob/master/Imagens/CapaRM.png)

## Instruções para configuração do Banco de Dados

Para executar a aplicação em sua máquina é necessário configurar o servidor e alterar algumas linhas de código.

### Configurar o Servidor
Primeiro é criar um banco de dados em um servidor MySQL, Para isso é necessário executar o arquivo **CriacaoDoBD.sql** no seu servidor MySQL.

### Modificar o código
Na classe **ConnectionFactory**, presente no pacote **DAL**, modifique as seguintes linhas

Linha    | Modificação
---------|------------
Linha 19 | Defina o valor da variável para o nome do **SERVER**
Linha 20 | Defina o valor da variável para o **USER** do **SERVER**
Linha 21 | Defina o valor da variável para o **PASS** do **USER**
Linha 22 | Defina o valor da variável para o nome do **DATABASE** ( "Sapataria" caso use **CriacaoDoBD.sql** )

É importante certificar que você tem acesso e permissão para modificar o banco de dados no servidor.

## Estoque
Os Sapatos são cadastrados e tem seu estoque administrado pelo sistema. Toda vez que uma venda é feita o estoque é automaticamente atualizado.
É possível excluir e atualizar o cadastro de sapatos em Estoque, porém é necessário ter **privilégios de administrador**.

![Estoque](https://github.com/GabrielIDSM/Sapataria-Rio-Verde/blob/master/Imagens/EstoqueRM.png)

![Estoque](https://github.com/GabrielIDSM/Sapataria-Rio-Verde/blob/master/Imagens/ModEstoqueRM.png)

## Vendas e Vendedores
O Sistema de vendas é responsável por modificar no banco de dados as unidades disponíveis de cada produto e calcular o valor final da venda. Não é possível efetuar a venda de um produto sem unidades disponíveis em estoque.

![Vendas](https://github.com/GabrielIDSM/Sapataria-Rio-Verde/blob/master/Imagens/VendaRM.png)

## Privilégios de Administrador
Vendedores com privilégios de admnistrador podem fazer alteração nos registros do banco de dados. Cadastros de Vendedores, Clientes e Produtos podem ser criados, modificados e excluídos.

## Colaboradores e contato
O Projeto é pessoal, feito por Gabriel Inácio ([Github](https://github.com/GabrielIDSM)/[LinkedIn](https://www.linkedin.com/in/gabriel-inacio-uff/)).

E-mail: gabrielinacio@id.uff.br
