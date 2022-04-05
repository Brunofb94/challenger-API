# challenger-API

rodar o projeto 
acessar a pasta cd BankAccounts 
rodar o projeto dotnet run  

acessar a pasta cd TestBankAccounts
rodar o projeto dotnet teste 

Criação de api com crud 

API simples para uma criação de conta bancária, focada apenas em conceitos básicos de api em dotnet.

#conexão

server=localhost;user id=root;password='suasenha";database=BankAccount
o modelo do banco de dados está no arquivo 'BankAccount.sql' 

para rodar o banco de dados junto com a api use o comando cl do Entity framework  abaixo
dotnet ef dbcontext scaffold "server=localhost;user id=root;password=suasenha; database=BankAccount" Pomelo.EntityFrameworkCore.MySql -o models --data-annotations --force

# ENDPOINTS E DADOS PARA CADASTRAR

('POST')
http://localhost:5205/ContaPoupanca

body 
{
        "tipo": "simples",
        "tax": 0.06,
        "idAccount": 9,
        "idAccountNavigation": null
}

('GET')
http://localhost:5205/ContaPoupanca

('GET') findby
http://localhost:5205/ContaPoupanca/{1

('DELETE') passar o id para deletar
http://localhost:5205/ContaPoupanca/{1

('PUT') passar o id de referência para atualizar
http://localhost:5205/ContaPoupanca/{1

body 
{
        "tipo": "simples",
        "tax": 0.08,
        "idAccount": 9,
        "idAccountNavigation": null
}
/////////////
('POST')
http://localhost:5205/ContaBancaria
body 
{
        "agency": 976,
        "startAccount": "2020-02-01",
        "numberAccount": 54,
        "balance": 1500
}

('GET')
http://localhost:5205/ContaBancaria

('GET') findby
http://localhost:5205/ContaBancaria/{1

('DELETE') passar o id para deletar
http://localhost:5205/ContaBancaria/{1

('PUT') passar o id de referência para atualizar
http://localhost:5205/ContaBancaria/{1

body 
{
       "agency": 976,
        "startAccount": "2020-02-01",
        "numberAccount": 54,
        "balance": 1500
}

('PUT') passar o id de referência para depositar no body passar o valor 
http://localhost:5205/ContaBancaria/depositar/7

body 
{
        "balance": 1500
}
('PUT') passar o id de referência para Retirar no body passar o valor 
http://localhost:5205/ContaBancaria/sacar/7

body 
{
        "balance": 1500
}
/////////////
('POST')
http://localhost:5205/ContaCorrente

body 
{
        "tipo": "simples",
        "idAccount": 9,
        "idAccountNavigation": null
}

('GET')
http://localhost:5205/ContaCorrente

('GET') findby
http://localhost:5205/ContaCorrente/{1

('DELETE') passar o id para deletar
http://localhost:5205/ContaCorrente/{1

('PUT') passar o id de referência para atualizar
http://localhost:5205/ContaCorrente/{1

body 
{
        "tipo": "simples",
        "idAccount": 9,
        "idAccountNavigation": null
}


