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

É importante se certificar que você tem acesso e permissão para modificar o banco de dados no servidor.

## Colaboradores e contato
O Projeto é pessoal, feito por Gabriel Inácio ([Github](https://github.com/GabrielIDSM)/[LinkedIn](https://www.linkedin.com/in/gabriel-inacio-uff/)).

E-mail: gabrielinacio@id.uff.br
