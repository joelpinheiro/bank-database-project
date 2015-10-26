DROP TRIGGER triggerdeletebalcao 

DROP TRIGGER triggerdeleteemprestimo 

DROP TRIGGER triggerdeletelevantamento 

DROP TRIGGER triggerdeletetransferencia 

DROP TRIGGER triggerdeletedeposito 

USE p4g10 

-- Caso um balcão tenha sido eliminado, actualiza o campo 'função' da tabela funcionário  
go 

CREATE TRIGGER triggerdeletebalcao 
ON dbo.balcao 
after DELETE 
AS 
  BEGIN 
      UPDATE dbo.funcionario 
      SET    funcao = 'Sem Balcão Origem' 
      WHERE  EXISTS (SELECT * 
                     FROM   dbo.funcionario, 
                            dbo.balcao 
                     WHERE  dbo.funcionario.nbalcao = dbo.balcao.nbalcao); 
  END; 

-- No caso de um emprestimo ser removido, remover também a operação associada  
go 

CREATE TRIGGER triggerdeleteemprestimo 
ON dbo.emprestimo 
after DELETE 
AS 
  BEGIN 
      DELETE dbo.operacao 
      FROM   dbo.operacao, 
             dbo.emprestimo 
      WHERE  dbo.operacao.idoperacao = dbo.emprestimo.idoperacao 

      DELETE dbo.associa 
      FROM   dbo.operacao, 
             dbo.emprestimo, 
             dbo.associa 
      WHERE  dbo.operacao.idoperacao = dbo.emprestimo.idoperacao 
             AND dbo.associa.idoperacao = dbo.operacao.idoperacao 

      DELETE dbo.solicitao
      FROM   dbo.operacao, 
             dbo.emprestimo, 
             dbo.solicitao 
      WHERE  dbo.operacao.idoperacao = dbo.emprestimo.idoperacao 
             AND dbo.solicitao.idoperacao = dbo.operacao.idoperacao 
  END; 

-- No caso de um levantamento ser removido, remover também a operação associada  
go 

CREATE TRIGGER triggerdeletelevantamento 
ON dbo.levantamento 
after DELETE 
AS 
  BEGIN 
      DELETE dbo.operacao 
      FROM   dbo.operacao, 
             dbo.levantamento 
      WHERE  dbo.operacao.idoperacao = dbo.levantamento.idoperacao 

      DELETE dbo.associa 
      FROM   dbo.operacao, 
             dbo.levantamento, 
             dbo.associa 
      WHERE  dbo.operacao.idoperacao = dbo.levantamento.idoperacao 
             AND dbo.associa.idoperacao = dbo.operacao.idoperacao 

      DELETE dbo.solicitao 
      FROM   dbo.operacao, 
             dbo.levantamento, 
             dbo.solicita 
      WHERE  dbo.operacao.idoperacao = dbo.levantamento.idoperacao 
             AND dbo.solicitao.idoperacao = dbo.operacao.idoperacao 
  END; 

-- No caso de uma transferência ser removida, remover também a operação associada  
go 

CREATE TRIGGER triggerdeletetransferencia 
ON dbo.transferencia 
after DELETE 
AS 
  BEGIN 
      DELETE dbo.operacao 
      FROM   dbo.operacao, 
             dbo.transferencia 
      WHERE  dbo.operacao.idoperacao = dbo.transferencia.idoperacao 

      DELETE dbo.associa 
      FROM   dbo.operacao, 
             dbo.transferencia, 
             dbo.associa 
      WHERE  dbo.operacao.idoperacao = dbo.transferencia.idoperacao 
             AND dbo.associa.idoperacao = dbo.operacao.idoperacao 

      DELETE dbo.solicitao 
      FROM   dbo.operacao, 
             dbo.transferencia, 
             dbo.solicitao 
      WHERE  dbo.operacao.idoperacao = dbo.transferencia.idoperacao 
             AND dbo.solicitao.idoperacao = dbo.operacao.idoperacao 
  END; 

-- No caso de um deposito ser removido, remover também a operação associada  
go 

CREATE TRIGGER triggerdeletedeposito 
ON dbo.deposito 
after DELETE 
AS 
  BEGIN 
      DELETE dbo.operacao 
      FROM   dbo.operacao, 
             dbo.deposito 
      WHERE  dbo.operacao.idoperacao = dbo.deposito.idoperacao 

      DELETE dbo.associa 
      FROM   dbo.operacao, 
             dbo.deposito, 
             dbo.associa 
      WHERE  dbo.operacao.idoperacao = dbo.deposito.idoperacao 
             AND dbo.associa.idoperacao = dbo.operacao.idoperacao 

      DELETE dbo.solicitao 
      FROM   dbo.operacao, 
             dbo.deposito, 
             dbo.solicitao 
      WHERE  dbo.operacao.idoperacao = dbo.deposito.idoperacao 
             AND dbo.solicitao.idoperacao = dbo.operacao.idoperacao 
  END; 