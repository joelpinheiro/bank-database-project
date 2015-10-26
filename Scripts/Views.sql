--Foram criadas Views para se poder visualizar em cada uma das forms criadas para a nossa aplicação, o conjunto de 
--dados pretendidos (estes dados sao adquiridos de várias entidades diferentes existentes na nossa BD)
--Transferencia 
go 

CREATE VIEW transferenciaview 
WITH schemabinding, encryption 
-- Schemabinding serve para que os objectos referenciados pelas nossa udf(que devolve uma view) não podem ser alvo de um drop
-- Encrypton para evitar que a view criada possa ser vista por qualquer utilizador usando sp_helptext ou syscomments
AS 
  SELECT operacao.idoperacao AS "ID Operação", 
         --Seleção dos campos pretendidos para a nossa view e como os queremos visiveis na nossa aplicação (por exemplo: ID Operação em vez de idOperacao)
         idtranferencia      AS "ID Transferência", 
         ncontaorigem        AS "Número Conta Origem", 
         ncontadestinatario  AS "Número Conta Destinatário", 
         valortransferencia  AS "Valor Transferência", 
         dbo.operacao.nif    AS "NIF Funcionario", 
         dbo.operacao.tipo   AS "Tipo", 
         dbo.operacao.data   AS "Data", 
         dbo.operacao.hora   AS "Hora" 
  FROM   dbo.transferencia, 
         dbo.operacao 
  WHERE  operacao.idoperacao = transferencia.idoperacao; --É utilizado o where para garantir que na view é visualizado apenas dados associados entre si 

--Emprestimo 
go 

CREATE VIEW emprestimoview 
WITH schemabinding, encryption 
AS 
  SELECT operacao.idoperacao AS "ID Operação", 
         idemprestimo        AS "ID Emprestimo", 
         nconta              AS "Número de Conta", 
         valoremprestimo     AS "Valor de Emprestimo", 
         tipoemprestimo      AS "Tipo Emprestimo", 
         taxajuro            AS "Taxa de Juro", 
         dbo.operacao.nif    AS "NIF Funcionario", 
         dbo.operacao.tipo   AS "Tipo", 
         dbo.operacao.data   AS "Data", 
         dbo.operacao.hora   AS "Hora" 
  FROM   dbo.emprestimo, 
         dbo.operacao 
  WHERE  operacao.idoperacao = emprestimo.idoperacao; 

--Deposito 
go 

CREATE VIEW depositoview 
WITH schemabinding, encryption 
AS 
  SELECT operacao.idoperacao AS "ID Operação", 
         iddeposito          AS "ID Deposito", 
         nconta              AS "Número de Conta", 
         valordeposito       AS "Valor Deposito", 
         dbo.operacao.nif    AS "NIF Funcionario", 
         dbo.operacao.tipo   AS "Tipo", 
         dbo.operacao.data   AS "Data", 
         dbo.operacao.hora   AS "Hora" 
  FROM   dbo.deposito, 
         dbo.operacao 
  WHERE  operacao.idoperacao = deposito.idoperacao; 

--Levantamento 
go 

CREATE VIEW levantamentosview 
WITH schemabinding, encryption 
AS 
  SELECT levantamento.idoperacao AS "ID Operação", 
         idlevantamento          AS "ID Levantamento", 
         montantelevantamento    AS "Montante Levantado", 
         nconta                  AS "Número de Conta", 
         dbo.operacao.nif        AS "NIF Funcionario", 
         dbo.operacao.tipo       AS "Tipo", 
         dbo.operacao.data       AS "Data", 
         dbo.operacao.hora       AS "Hora" 
  FROM   dbo.levantamento, 
         dbo.operacao 
  WHERE  operacao.idoperacao = levantamento.idoperacao; 

--Operação 
go 

CREATE VIEW operacaoview 
WITH schemabinding, encryption 
AS 
  SELECT DISTINCT dbo.operacao.idoperacao AS "ID Operação", 
                  identificacao.nome      AS "Nome", 
                  identificacao.nif       AS "NIF Cliente", 
                  cliente.nconta          AS "Número Conta", 
                  dbo.operacao.nif        AS "NIF Funcionario", 
                  dbo.operacao.tipo       AS "Tipo", 
                  dbo.operacao.data       AS "Data", 
                  dbo.operacao.hora       AS "Hora" 
  FROM   dbo.identificacao, 
         dbo.solicitacao, 
         dbo.operacao, 
         dbo.cliente, 
         dbo.funcionario 
  WHERE  dbo.identificacao.nif = cliente.nif 
         AND cliente.nif = solicitacao.nif 
         AND solicitacao.idoperacao = operacao.idoperacao; 

--Conta 
go 

CREATE VIEW contaview 
WITH schemabinding, encryption 
AS 
  SELECT DISTINCT identificacao.nome AS "Nome", 
                  identificacao.nif  AS "NIF", 
                  conta.nconta       AS "Número de Conta", 
                  saldo              AS "Saldo", 
                  conta.tipoconta    AS "Tipo", 
                  balcaoassociado    AS "Balcão Associado" 
  FROM   dbo.identificacao, 
         dbo.cliente, 
         dbo.conta, 
         dbo.tem 
  WHERE  identificacao.nif = tem.nif; 

-- Devolve todos os campos da tabela identificacão  
go 

CREATE VIEW identificacaoview 
WITH encryption 
AS 
  SELECT dbo.identificacao.* 
  FROM   dbo.identificacao; 

-- Devolve o nome, código postal, país e todos os campos da tabela cliente  
go 

CREATE VIEW clientesviewidentificacao 
WITH encryption 
AS 
  SELECT dbo.identificacao.nome, 
         dbo.cliente.*, 
         dbo.identificacao.ntelefone, 
         dbo.identificacao.datanascimento, 
         dbo.identificacao.país, 
         dbo.identificacao.localidade, 
         dbo.identificacao.endereco, 
         dbo.identificacao.codpostal, 
         dbo.identificacao.gênero, 
         dbo.identificacao.idade 
  FROM   dbo.identificacao, 
         dbo.cliente 
  WHERE  dbo.identificacao.nif = dbo.cliente.nif 

-- Devolve o nome, código postal, país e todos os campos da tabela funcionário  
go 

CREATE VIEW funcionariosviewidentificacao 
WITH encryption 
AS 
  SELECT dbo.identificacao.nome, 
         dbo.funcionario.*, 
         dbo.identificacao.ntelefone, 
         dbo.identificacao.datanascimento, 
         dbo.identificacao.país, 
         dbo.identificacao.localidade, 
         dbo.identificacao.endereco, 
         dbo.identificacao.codpostal, 
         dbo.identificacao.gênero, 
         dbo.identificacao.idade 
  FROM   dbo.identificacao, 
         dbo.funcionario 
  WHERE  dbo.identificacao.nif = dbo.funcionario.nif 

-- Devolve todos os campos da tabela balcão  
go 

CREATE VIEW balcaoview 
WITH encryption 
AS 
  SELECT dbo.balcao.* 
  FROM   dbo.balcao; 

---Views Criada numa fase inicial, mas que depois foram substituidas pelas views existente em cima
/* 
go  

CREATE VIEW transferenciaview  
WITH schemabinding, encryption  
AS  
SELECT idoperacao,  
       idtranferencia,  
       ncontaorigem,  
       ncontadestinatario,  
       valortransferencia  
FROM   dbo.transferencia;  

go  

alter VIEW transferenciaviewcliente  
WITH schemabinding, encryption  
AS  
SELECT identificacao.nome as "Nome",  
       identificacao.nif as "NIF",  
       transferencia.idoperacao as "ID Operação",  
       idtranferencia as "ID Transferência",  
       ncontaorigem as "Número conta origem",  
       ncontadestinatario as "Número conta destino",  
       valortransferencia as "Valor Transferência"  
FROM   dbo.transferencia,  
       dbo.identificacao,  
       dbo.operacao,  
       dbo.cliente, 
 dbo.solicitacao, 
 dbo.associa, 
 dbo.tem  
WHERE tem.nConta=cliente.nConta and tem.NIF=cliente.NIF and transferencia.idOperacao=operacao.idOperacao and identificacao.NIF=cliente.NIF and solicitacao.idOperacao=operacao.idOperacao and solicitacao.NIF=identificacao.NIF
group by nome,identificacao.NIF,transferencia.idOperacao,idTranferencia,transferencia.nContaOrigem,nContaOrigem,nContaDestinatario,valorTransferencia


go  

alter VIEW emprestimoview  
WITH schemabinding, encryption  
AS  
SELECT idoperacao as "ID Operação",  
       idemprestimo as "ID Emprestimo",  
       nconta as "Número de Conta",  
       valoremprestimo as "Valor de Emprestimo",  
       tipoemprestimo as "Tipo Emprestimo",  
       taxajuro as "Taxa de Juro"  
FROM   dbo.emprestimo;  

go  

alter VIEW emprestimoviewcliente  
WITH schemabinding, encryption  
AS  
SELECT identificacao.nome as "Nome",  
       identificacao.nif as "NIF",  
       emprestimo.idoperacao as "ID Operação",  
       idemprestimo as "ID Emprestimo",  
       emprestimo.nconta as "Número Conta",  
       valoremprestimo as "Valor Emprestimo",  
       tipoemprestimo as "Tipo",  
       taxajuro as "Taxa de Juro"  
FROM   dbo.emprestimo,  
       dbo.identificacao,  
       dbo.operacao,  
       dbo.cliente, 
 dbo.solicitacao, 
 dbo.associa, 
 dbo.tem  
WHERE tem.nConta=cliente.nConta and tem.NIF=cliente.NIF and emprestimo.idOperacao=operacao.idOperacao and identificacao.NIF=cliente.NIF and solicitacao.idOperacao=operacao.idOperacao and solicitacao.NIF=identificacao.NIF
group by nome,identificacao.NIF,emprestimo.idOperacao,idEmprestimo,emprestimo.nconta,valorEmprestimo, tipoemprestimo,taxajuro 

go  

alter VIEW depositoview  
WITH schemabinding, encryption  
AS  
SELECT idOperacao as "ID Operação",  
       idDeposito as "ID DEposito",  
       nConta as "Número de Conta",  
       valorDeposito as "Valor Deposito"  
FROM   dbo.deposito;  

go  

alter VIEW depositoviewcliente  
WITH schemabinding, encryption  
AS  
SELECT identificacao.nome as "Nome",  
       identificacao.NIF as "NIF",  
       deposito.idOperacao as "ID Operação",  
       idDeposito as "ID Deposito",  
       deposito.nconta as "Número Conta",  
       valorDeposito as "Valor Deposito"  
FROM   dbo.deposito,  
       dbo.identificacao,  
       dbo.operacao,  
       dbo.cliente, 
 dbo.solicitacao, 
 dbo.associa, 
 dbo.tem  
WHERE tem.nConta=cliente.nConta and tem.NIF=cliente.NIF and deposito.idOperacao=operacao.idOperacao and identificacao.NIF=cliente.NIF and solicitacao.idOperacao=operacao.idOperacao and solicitacao.NIF=identificacao.NIF
group by nome,identificacao.NIF,deposito.idOperacao,iddeposito,deposito.nconta,valordeposito 

go  

CREATE VIEW levantamentosview  
WITH schemabinding, encryption  
AS  
SELECT idlevantamento,  
       montantelevantamento,  
       nconta  
FROM   dbo.levantamento;  

go  

alter VIEW levantamentosviewcliente  
WITH schemabinding, encryption  
AS  
SELECT identificacao.nome as "Nome",  
       identificacao.nif as "NIF",  
 levantamento.idOperacao as "ID Operacao", 
       idlevantamento as "ID Levantamento",  
       montantelevantamento as "Montante Levantado",  
       levantamento.nconta as "Número de Conta"  
FROM   dbo.levantamento,  
       dbo.identificacao,  
       dbo.operacao,  
       dbo.cliente, 
 dbo.solicitacao, 
 dbo.associa, 
 dbo.tem  
WHERE tem.nConta=cliente.nConta and tem.NIF=cliente.NIF and levantamento.idOperacao=operacao.idOperacao and identificacao.NIF=cliente.NIF and solicitacao.idOperacao=operacao.idOperacao and solicitacao.NIF=identificacao.NIF
group by nome,identificacao.NIF,levantamento.idOperacao,idLevantamento,Levantamento.nconta,montanteLevantamento, levantamento.nConta 


go  

alter VIEW operacaoview  
WITH schemabinding, encryption  
AS  
SELECT DISTINCT dbo.operacao.idoperacao as "ID Operação",  
                identificacao.nome as "Nome",  
                identificacao.nif AS "NIF Cliente",  
                cliente.nconta as "Número Conta",  
                dbo.operacao.nif  AS "NIF Funcionario",  
                dbo.operacao.tipo as "Tipo",  
                dbo.operacao.data as "Data",  
                dbo.operacao.hora as "Hora"  
FROM   dbo.identificacao,  
       dbo.solicitacao,  
       dbo.operacao,  
       dbo.cliente,  
       dbo.funcionario  
WHERE  dbo.identificacao.nif = cliente.nif  
       AND cliente.nif = solicitacao.nif  
       AND solicitacao.idoperacao = operacao.idoperacao;  
 */ 