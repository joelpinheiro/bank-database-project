
--De forma a actualizar os saldos das contas após uma dada operação foram usados store procedures que para além de criarem a operação propriamente dita, verificam se é possivel 
--realizar a operação. Caso nao seja nao criam a operação e emitem uma mensagem de erro. Caso seja possivel, criam a operação pretendida e actualizam os saldo(s) da(s) conta(s) envolvida(s).
-- Foram usadas transactions para permitir que a actualização da BD seja feita com maior segurança
--Levantamento 
USE [p4g10] 

go 

SET ansi_nulls ON 

go 

SET quoted_identifier ON 

go 

create PROCEDURE [dbo].[Spinsertlevantamento] @idOperacao           INT, 
                                             --Paramentros de entrada necessários para a criação de um levantamento 
                                             @idLevantamento       INT, 
                                             @montanteLevantamento MONEY, 
                                             @nConta               INT 
AS 
    IF( EXISTS(SELECT * 
               FROM   conta 
               WHERE  nconta = @nConta 
                      AND saldo < @montanteLevantamento) ) 
      -- Condição de forma a garantir que é possivel realizar a operação pedida 
      BEGIN 
          RETURN 'Não tem saldo suficiente na conta!' --Mensagem de erro 
      END 

  BEGIN TRANSACTION
	  INSERT INTO dbo.levantamento -- Começa a transation
                  --Sendo permitida a operação, definimos onde vamos colocar os dados recebidos como parametros 
                  ([idoperacao], 
                   [idlevantamento], 
                   [montantelevantamento], 
                   [nconta]) 
      VALUES      (@idOperacao, 
                   @idLevantamento, 
                   @montanteLevantamento, 
                   @nConta) 

      UPDATE conta 
      SET    saldo = saldo - @montanteLevantamento 
      WHERE  nconta = @nConta -- Update do saldo na conta afectada pela operação 
	  
	  COMMIT TRAN -- transation é bem sucedida
	  BEGIN		  -- transation não foi bem sucedida, é feito o rollback
		PRINT	'A transacção precisa de rollback'	
			ROLLBACK	TRAN	
	  END


--Deposito 
go 

create PROCEDURE dbo.Spinsertdeposito @idOperacao    INT, 
                                     @idDeposito    INT, 
                                     @nconta        INT, 
                                     @valorDeposito MONEY 
AS 
    BEGIN TRANSACTION
	INSERT INTO dbo.deposito 
                ([idoperacao], 
                 [iddeposito], 
                 [nconta], 
                 [valordeposito]) 
    VALUES      ( @idOperacao, 
                  @idDeposito, 
                  @nconta, 
                  @valorDeposito) 

    UPDATE conta 
    SET    saldo = saldo + @valorDeposito 
    WHERE  nconta = @nConta; 

	COMMIT TRAN
	  BEGIN	
		PRINT	'A transacção precisa de rollback'	
			ROLLBACK	TRAN	
	  END


--TRANSFERENCIA  

GO
create PROCEDURE dbo.Spinserttransferencia @idOperacao         INT, 
                                          @idTranferencia     INT, 
                                          @nContaOrigem       INT, 
                                          @nContaDestinatario INT, 
                                          @valorTransferencia MONEY 
AS 
    IF( EXISTS(SELECT * 
               FROM   conta 
               WHERE  nconta = @nContaOrigem 
                      AND saldo < @valorTransferencia) ) 
      BEGIN 
          RETURN 'Não tem saldo suficiente na conta!' 
      END 

	BEGIN TRANSACTION
    INSERT INTO dbo.transferencia 
                ([idoperacao], 
                 [idtranferencia], 
                 [ncontaorigem], 
                 [ncontadestinatario], 
                 [valortransferencia]) 
    VALUES      ( @idOperacao, 
                  @idTranferencia, 
                  @nContaOrigem, 
                  @nContaDestinatario, 
                  @valorTransferencia) 

    UPDATE conta 
    SET    saldo = saldo + @valorTransferencia 
    WHERE  nconta = @nContaDestinatario 

    UPDATE conta 
    SET    saldo = saldo - @valorTransferencia 
    WHERE  nconta = @nContaOrigem; 

	COMMIT TRAN
	  BEGIN	
		PRINT	'A transacção precisa de rollback'	
			ROLLBACK	TRAN	
	  END
	  A

--Emprestimo 
go 

create PROCEDURE dbo.Spinsertemprestimo @idOperacao      INT, 
                                       @idEmprestimo    INT, 
                                       @taxaJuro        INT, 
                                       @nconta          INT, 
                                       @valorEmprestimo MONEY, 
                                       @tipoEmprestimo  VARCHAR(100) 
AS 
    BEGIN TRANSACTION
	INSERT INTO dbo.emprestimo 
                ([idoperacao], 
                 [idemprestimo], 
                 [taxajuro], 
                 [nconta], 
                 [valoremprestimo], 
                 [tipoemprestimo]) 
    VALUES      ( @idOperacao, 
                  @idEmprestimo, 
                  @taxaJuro, 
                  @nconta, 
                  @valorEmprestimo, 
                  @tipoEmprestimo) 

    UPDATE conta 
    SET    saldo = saldo + @valorEmprestimo 
    WHERE  nconta = @nConta; 

	COMMIT TRAN
	  BEGIN	
		PRINT	'A transacção precisa de rollback'	
			ROLLBACK	TRAN	
	  END
