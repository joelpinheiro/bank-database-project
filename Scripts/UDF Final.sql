-- AS UDF foram criadas para a pesquisa por campos da nossa aplicação, foram criadas UDF's para cada uma das operações visiveis para o utilizador e para a entidade cliente, apesar de no backend ser necessário recorrer a mais entidades.
--Cada UDF recebe como parametro 3 campos, estes campos foram escolhidos por serem os mais unicos para a respectivel pesquisa.O objectivo destas UDF era tambem permitir a pesquisa usando qualuqer uma das possiveis combinaições (usar apenas 2 campos para pesquisar,usar os 3, usar apenas um, etc)
--Deposito 
go 

CREATE FUNCTION dbo.Udfdeposito(@idOperacao INT=0, 
                                @idDeposito INT=0, 
                                @nconta     INT=0) --Parametros de entrada  
returns @table TABLE ( 
  "nome"         VARCHAR(200), 
  "nif"          INT, 
  "id operação"  INT, 
  "id deposito"  INT, 
  "número conta" INT ) 
--Maneira como queremos que fique escrito na nossa base de dados os dados que iremos apresentar
WITH schemabinding, encryption 
  -- Schemabinding serve para que os objectos referenciados pelas nossa udf(que devolve uma view) não podem ser alvo de um drop
  BEGIN 
      -- Encrypton para evitar que a view criada possa ser vista por qualquer utilizador usando sp_helptext ou syscomments
      --Declaração dos varios if para cada um dos cenarios de pesquisa 
      --quando necessario atraves do where é definido as condiçoes que devem ser cumpridas para aparecerem apenas os dados pretendidos
      IF( @idOperacao = NULL 
          AND @nconta = NULL 
          AND @idDeposito = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            idoperacao             AS "ID Operação", 
                            iddeposito             AS "ID Deposito", 
                            nconta                 AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.deposito 
        END 

      IF( @idOperacao >= 0 
          AND @nconta >= 0 
          AND @idDeposito >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome       AS "Nome", 
                            nif        AS "NIF", 
                            idoperacao AS "ID Operação", 
                            iddeposito AS "ID Deposito", 
                            nconta     AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.deposito 
            WHERE  nconta = @nconta 
                   AND iddeposito = @idDeposito 
                   AND idoperacao = @idOperacao 
        END 

      IF( @idOperacao = NULL 
          AND @nconta >= 0 
          AND @idDeposito >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome       AS "Nome", 
                            nif        AS "NIF", 
                            idoperacao AS "ID Operação", 
                            iddeposito AS "ID Deposito", 
                            nconta     AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.deposito 
            WHERE  nconta = @nconta 
                   AND iddeposito = @idDeposito 
        END 

      IF( @idOperacao = NULL 
          AND @nconta >= 0 
          AND @idDeposito = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome       AS "Nome", 
                            nif        AS "NIF", 
                            idoperacao AS "ID Operação", 
                            iddeposito AS "ID Deposito", 
                            nconta     AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.deposito 
            WHERE  nconta = @nconta 
        END 

      IF( @idOperacao = NULL 
          AND @nconta = NULL 
          AND @idDeposito >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome       AS "Nome", 
                            nif        AS "NIF", 
                            idoperacao AS "ID Operação", 
                            iddeposito AS "ID Deposito", 
                            nconta     AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.deposito 
            WHERE  iddeposito = @idDeposito 
        END 

      IF( @idOperacao >= 0 
          AND @nconta = NULL 
          AND @idDeposito = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome       AS "Nome", 
                            nif        AS "NIF", 
                            idoperacao AS "ID Operação", 
                            iddeposito AS "ID Deposito", 
                            nconta     AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.deposito 
            WHERE  idoperacao = @idOperacao 
        END 

      IF( @idOperacao >= 0 
          AND @nconta >= 0 
          AND @idDeposito = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome       AS "Nome", 
                            nif        AS "NIF", 
                            idoperacao AS "ID Operação", 
                            iddeposito AS "ID Deposito", 
                            nconta     AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.deposito 
            WHERE  nconta = @nconta 
                   AND idoperacao = @idOperacao 
        END 

      IF( @idOperacao >= 0 
          AND @nconta = NULL 
          AND @idDeposito >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome       AS "Nome", 
                            nif        AS "NIF", 
                            idoperacao AS "ID Operação", 
                            iddeposito AS "ID Deposito", 
                            nconta     AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.deposito 
            WHERE  idoperacao = @idOperacao 
                   AND iddeposito = @idDeposito 
        END 

      RETURN 
  END; 

--Emprestimo 
go 

CREATE FUNCTION dbo.Udfemprestimo(@idOperacao   INT=0, 
                                  @idEmprestimo INT=0, 
                                  @nconta       INT=0) 
returns @table TABLE ( 
  "nome"          VARCHAR(200), 
  "nif"           INT, 
  "id operação"   INT, 
  "id emprestimo" INT, 
  "número conta"  INT ) 
WITH schemabinding, encryption 
  BEGIN 
      IF( @idOperacao = NULL 
          AND @nconta = NULL 
          AND @idEmprestimo = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            idoperacao             AS "ID Operação", 
                            idemprestimo           AS "ID Emprestimo", 
                            nconta                 AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.emprestimo 
        END 

      IF( @idOperacao >= 0 
          AND @nconta >= 0 
          AND @idEmprestimo >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome         AS "Nome", 
                            nif          AS "NIF", 
                            idoperacao   AS "ID Operação", 
                            idemprestimo AS "ID Emprestimo", 
                            nconta       AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.emprestimo 
            WHERE  nconta = @nconta 
                   AND idemprestimo = @idEmprestimo 
                   AND idoperacao = @idOperacao 
        END 

      IF( @idOperacao = NULL 
          AND @nconta >= 0 
          AND @idEmprestimo >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome         AS "Nome", 
                            nif          AS "NIF", 
                            idoperacao   AS "ID Operação", 
                            idemprestimo AS "ID Emprestimo", 
                            nconta       AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.emprestimo 
            WHERE  nconta = @nconta 
                   AND idemprestimo = @idEmprestimo 
        END 

      IF( @idOperacao = NULL 
          AND @nconta >= 0 
          AND @idEmprestimo = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome         AS "Nome", 
                            nif          AS "NIF", 
                            idoperacao   AS "ID Operação", 
                            idemprestimo AS "ID Emprestimo", 
                            nconta       AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.emprestimo 
            WHERE  nconta = @nconta 
        END 

      IF( @idOperacao = NULL 
          AND @nconta = NULL 
          AND @idEmprestimo >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome         AS "Nome", 
                            nif          AS "NIF", 
                            idoperacao   AS "ID Operação", 
                            idemprestimo AS "ID Emprestimo", 
                            nconta       AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.emprestimo 
            WHERE  idemprestimo = @idEmprestimo 
        END 

      IF( @idOperacao >= 0 
          AND @nconta = NULL 
          AND @idEmprestimo = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome         AS "Nome", 
                            nif          AS "NIF", 
                            idoperacao   AS "ID Operação", 
                            idemprestimo AS "ID Emprestimo", 
                            nconta       AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.emprestimo 
            WHERE  idoperacao = @idOperacao 
        END 

      IF( @idOperacao >= 0 
          AND @nconta >= 0 
          AND @idEmprestimo = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome         AS "Nome", 
                            nif          AS "NIF", 
                            idoperacao   AS "ID Operação", 
                            idemprestimo AS "ID Emprestimo", 
                            nconta       AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.emprestimo 
            WHERE  nconta = @nconta 
                   AND idoperacao = @idOperacao 
        END 

      IF( @idOperacao >= 0 
          AND @nconta = NULL 
          AND @idEmprestimo >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome         AS "Nome", 
                            nif          AS "NIF", 
                            idoperacao   AS "ID Operação", 
                            idemprestimo AS "ID Emprestimo", 
                            nconta       AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.emprestimo 
            WHERE  idoperacao = @idOperacao 
                   AND idemprestimo = @idEmprestimo 
        END 

      RETURN 
  END; 

--Levantamento 
go 

CREATE FUNCTION dbo.Udflevantamento(@idOperacao     INT=0, 
                                    @idLevantamento INT=0, 
                                    @nConta         INT=0) 
returns @table TABLE ( 
  "nome"            VARCHAR(200), 
  "nif"             INT, 
  "id operação"     INT, 
  "id levantamento" INT, 
  "número conta"    INT ) 
WITH schemabinding, encryption 
  BEGIN 
      IF( @idOperacao = NULL 
          AND @nConta = NULL 
          AND @idLevantamento = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            idoperacao             AS "ID Operação", 
                            idlevantamento         AS "ID Levantamento", 
                            nconta                 AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.levantamento 
        END 

      IF( @idOperacao >= 0 
          AND @nConta >= 0 
          AND @idLevantamento >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idlevantamento AS "ID Levantamento", 
                            nconta         AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.levantamento 
            WHERE  nconta = @nConta 
                   AND idlevantamento = @idLevantamento 
                   AND idoperacao = @idOperacao 
        END 

      IF( @idOperacao = NULL 
          AND @nConta >= 0 
          AND @idLevantamento >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idlevantamento AS "ID Levantamento", 
                            nconta         AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.levantamento 
            WHERE  nconta = @nConta 
                   AND idlevantamento = @idLevantamento 
        END 

      IF( @idOperacao = NULL 
          AND @nConta >= 0 
          AND @idLevantamento = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idlevantamento AS "ID Levantamento", 
                            nconta         AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.levantamento 
            WHERE  nconta = @nConta 
        END 

      IF( @idOperacao = NULL 
          AND @nConta = NULL 
          AND @idLevantamento >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idlevantamento AS "ID Levantamento", 
                            nconta         AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.levantamento 
            WHERE  idlevantamento = @idLevantamento 
        END 

      IF( @idOperacao >= 0 
          AND @nConta = NULL 
          AND @idLevantamento = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idlevantamento AS "ID Levantamento", 
                            nconta         AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.levantamento 
            WHERE  idoperacao = @idOperacao 
        END 

      IF( @idOperacao >= 0 
          AND @nConta >= 0 
          AND @idLevantamento = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idlevantamento AS "ID Levantamento", 
                            nconta         AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.levantamento 
            WHERE  nconta = @nConta 
                   AND idoperacao = @idOperacao 
        END 

      IF( @idOperacao >= 0 
          AND @nConta = NULL 
          AND @idLevantamento >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idlevantamento AS "ID Levantamento", 
                            nconta         AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.levantamento 
            WHERE  idoperacao = @idOperacao 
                   AND idlevantamento = @idLevantamento 
        END 

      RETURN 
  END; 

--Transferencia 
go 

CREATE FUNCTION dbo.Udftransferencia(@idOperacao     INT=0, 
                                     @idTranferencia INT=0, 
                                     @nContaOrigem   INT=0) 
returns @table TABLE ( 
  "nome"                VARCHAR(200), 
  "nif"                 INT, 
  "id operação"         INT, 
  "id transferência"    INT, 
  "número conta origem" INT ) 
WITH schemabinding, encryption 
  BEGIN 
      IF( @idOperacao = NULL 
          AND @nContaOrigem = NULL 
          AND @idTranferencia = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            idoperacao             AS "ID Operação", 
                            idtranferencia         AS "ID Transferência", 
                            ncontaorigem           AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.transferencia 
        END 

      IF( @idOperacao >= 0 
          AND @nContaOrigem >= 0 
          AND @idTranferencia >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idtranferencia AS "ID Transferência", 
                            ncontaorigem   AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.transferencia 
            WHERE  ncontaorigem = @nContaOrigem 
                   AND idtranferencia = @idTranferencia 
                   AND idoperacao = @idOperacao 
        END 

      IF( @idOperacao = NULL 
          AND @nContaOrigem >= 0 
          AND @idTranferencia >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idtranferencia AS "ID Transferência", 
                            ncontaorigem   AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.transferencia 
            WHERE  ncontaorigem = @nContaOrigem 
                   AND idtranferencia = @idTranferencia 
        END 

      IF( @idOperacao = NULL 
          AND @nContaOrigem >= 0 
          AND @idTranferencia = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idtranferencia AS "ID Transferência", 
                            ncontaorigem   AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.transferencia 
            WHERE  ncontaorigem = @nContaOrigem 
        END 

      IF( @idOperacao = NULL 
          AND @nContaOrigem = NULL 
          AND @idTranferencia >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idtranferencia AS "ID Transferência", 
                            ncontaorigem   AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.transferencia 
            WHERE  idtranferencia = @idTranferencia 
        END 

      IF( @idOperacao >= 0 
          AND @nContaOrigem = NULL 
          AND @idTranferencia = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idtranferencia AS "ID Transferência", 
                            ncontaorigem   AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.transferencia 
            WHERE  idoperacao = @idOperacao 
        END 

      IF( @idOperacao >= 0 
          AND @nContaOrigem >= 0 
          AND @idTranferencia = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idtranferencia AS "ID Transferência", 
                            ncontaorigem   AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.transferencia 
            WHERE  ncontaorigem = @nContaOrigem 
                   AND idoperacao = @idOperacao 
        END 

      IF( @idOperacao >= 0 
          AND @nContaOrigem = NULL 
          AND @idTranferencia >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT nome           AS "Nome", 
                            nif            AS "NIF", 
                            idoperacao     AS "ID Operação", 
                            idtranferencia AS "ID Transferência", 
                            ncontaorigem   AS "número conta" 
            FROM   dbo.identificacao, 
                   dbo.transferencia 
            WHERE  idoperacao = @idOperacao 
                   AND idtranferencia = @idTranferencia 
        END 

      RETURN 
  END; 

--Conta 
go 

CREATE FUNCTION dbo.Udfconta(@Nome   VARCHAR(200), 
                             @NIF    INT=0, 
                             @nConta INT=0) 
returns @table TABLE ( 
  "nome"             VARCHAR(200), 
  "nif"              INT, 
  "saldo"            MONEY, 
  "tipo conta"       VARCHAR(200), 
  "balcão associado" VARCHAR(200)) 
WITH schemabinding, encryption 
  BEGIN 
      IF( @Nome = NULL 
          AND @nConta = NULL 
          AND @NIF = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            saldo                  AS "Saldo", 
                            tipoconta              AS "Tipo Conta", 
                            balcaoassociado        AS "Balcão Associado" 
            FROM   dbo.identificacao, 
                   dbo.conta 
            WHERE  dbo.identificacao.nif = dbo.conta.nif 
        END 

      IF( Datalength(@Nome) != 0 
          AND @nConta >= 0 
          AND @NIF >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            saldo                  AS "Saldo", 
                            tipoconta              AS "Tipo Conta", 
                            balcaoassociado        AS "Balcão Associado" 
            FROM   dbo.identificacao, 
                   dbo.conta 
            WHERE  nconta = @nConta 
                   AND nif = @NIF 
                   AND nome = @Nome 
                   AND dbo.identificacao.nif = dbo.conta.nif 
        END 

      IF( Datalength(@Nome) = 0 
          AND @nConta >= 0 
          AND @NIF >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            saldo                  AS "Saldo", 
                            tipoconta              AS "Tipo Conta", 
                            balcaoassociado        AS "Balcão Associado" 
            FROM   dbo.identificacao, 
                   dbo.conta 
            WHERE  nconta = @nConta 
                   AND nif = @NIF 
                   AND dbo.identificacao.nif = dbo.conta.nif 
        END 

      IF( Datalength(@Nome) = 0 
          AND @nConta >= 0 
          AND @NIF = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            saldo                  AS "Saldo", 
                            tipoconta              AS "Tipo Conta", 
                            balcaoassociado        AS "Balcão Associado" 
            FROM   dbo.identificacao, 
                   dbo.conta 
            WHERE  nconta = @nConta 
                   AND dbo.identificacao.nif = dbo.conta.nif 
        END 

      IF( Datalength(@Nome) = 0 
          AND @nConta = NULL 
          AND @NIF >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            saldo                  AS "Saldo", 
                            tipoconta              AS "Tipo Conta", 
                            balcaoassociado        AS "Balcão Associado" 
            FROM   dbo.identificacao, 
                   dbo.conta 
            WHERE  nif = @NIF 
                   AND dbo.identificacao.nif = dbo.conta.nif 
        END 

      IF( Datalength(@Nome) != 0 
          AND @nConta = NULL 
          AND @NIF = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            saldo                  AS "Saldo", 
                            tipoconta              AS "Tipo Conta", 
                            balcaoassociado        AS "Balcão Associado" 
            FROM   dbo.identificacao, 
                   dbo.conta 
            WHERE  nome = @Nome 
                   AND dbo.identificacao.nif = dbo.conta.nif 
        END 

      IF( Datalength(@Nome) != 0 
          AND @nConta >= 0 
          AND @NIF = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            saldo                  AS "Saldo", 
                            tipoconta              AS "Tipo Conta", 
                            balcaoassociado        AS "Balcão Associado" 
            FROM   dbo.identificacao, 
                   dbo.conta 
            WHERE  nconta = @nConta 
                   AND nome = @Nome 
                   AND dbo.identificacao.nif = dbo.conta.nif 
        END 

      IF( Datalength(@Nome) != 0 
          AND @nConta = NULL 
          AND @NIF >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            nif                    AS "NIF", 
                            saldo                  AS "Saldo", 
                            tipoconta              AS "Tipo Conta", 
                            balcaoassociado        AS "Balcão Associado" 
            FROM   dbo.identificacao, 
                   dbo.conta 
            WHERE  nome = @Nome 
                   AND nif = @NIF 
                   AND dbo.identificacao.nif = dbo.conta.nif 
        END 

      RETURN 
  END; 

--Cliente 
go 

CREATE FUNCTION dbo.Udfcliente(@Nome      VARCHAR(200)=NULL, 
                               @NIF       INT=0, 
                               @idCliente INT=0) 
returns @table TABLE ( 
  "nome"            VARCHAR(200), 
  "nif"             INT, 
  "id cliente"      INT, 
  "número de conta" INT, 
  "saldo"           MONEY ) 
WITH schemabinding, encryption 
  -- Schemabinding serve para que os objectos referenciados pelas nossa udf não podem ser alvo de um drop
  BEGIN 
      -- Encrypton para evitar que a view criada possa ser vista por qualquer utilizador usando sp_helptext ou syscomments
      --Declaração dos varios if para cada um dos cenarios de pesquisa 
      --quando necessario atraves do where é definido as condiçoes que devem ser cumpridas para aparecerem apenas os dados pretendidos
      IF( @Nome = NULL 
          AND @NIF = NULL 
          AND @idCliente = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            cliente.nif            AS "NIF", 
                            idcliente              AS "ID Cliente", 
                            conta.nconta           AS "Número conta", 
                            saldo                  AS "Saldo" 
            FROM   dbo.identificacao, 
                   dbo.cliente, 
                   dbo.conta 
            WHERE  identificacao.nif = cliente.nif 
                   AND conta.nconta = cliente.nconta; 
        END 

      IF( @Nome >= 0 
          AND @NIF >= 0 
          AND @idCliente >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            cliente.nif            AS "NIF", 
                            idcliente              AS "ID Cliente", 
                            conta.nconta           AS "Número conta", 
                            saldo                  AS "Saldo" 
            FROM   dbo.identificacao, 
                   dbo.cliente, 
                   dbo.conta 
            WHERE  cliente.nif = @NIF 
                   AND idcliente = @idCliente 
                   AND nome = @Nome 
                   AND identificacao.nif = cliente.nif 
                   AND conta.nconta = cliente.nconta; 
        END 

      IF( @Nome = NULL 
          AND @NIF >= 0 
          AND @idCliente >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            cliente.nif            AS "NIF", 
                            idcliente              AS "ID Cliente", 
                            conta.nconta           AS "Número conta", 
                            saldo                  AS "Saldo" 
            FROM   dbo.identificacao, 
                   dbo.cliente, 
                   dbo.conta 
            WHERE  cliente.nif = @NIF 
                   AND nome = @idCliente 
                   AND identificacao.nif = cliente.nif 
                   AND conta.nconta = cliente.nconta; 
        END 

      IF( @Nome = NULL 
          AND @NIF >= 0 
          AND @idCliente = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            cliente.nif            AS "NIF", 
                            idcliente              AS "ID Cliente", 
                            conta.nconta           AS "Número conta", 
                            saldo                  AS "Saldo" 
            FROM   dbo.identificacao, 
                   dbo.cliente, 
                   dbo.conta 
            WHERE  cliente.nif = @NIF 
                   AND identificacao.nif = cliente.nif 
                   AND conta.nconta = cliente.nconta; 
        END 

      IF( @Nome = NULL 
          AND @NIF = NULL 
          AND @idCliente >= 0 ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            cliente.nif            AS "NIF", 
                            idcliente              AS "ID Cliente", 
                            conta.nconta           AS "Número conta", 
                            saldo                  AS "Saldo" 
            FROM   dbo.identificacao, 
                   dbo.cliente, 
                   dbo.conta 
            WHERE  idcliente = @idCliente 
                   AND identificacao.nif = cliente.nif 
                   AND conta.nconta = cliente.nconta; 
        END 

      IF( @Nome >= 0 
          AND @NIF = NULL 
          AND @idCliente = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            cliente.nif            AS "NIF", 
                            idcliente              AS "ID Cliente", 
                            conta.nconta           AS "Número conta", 
                            saldo                  AS "Saldo" 
            FROM   dbo.identificacao, 
                   dbo.cliente, 
                   dbo.conta 
            WHERE  nome = @Nome 
                   AND identificacao.nif = cliente.nif 
                   AND conta.nconta = cliente.nconta; 
        END 

      IF( @Nome >= 0 
          AND @NIF >= 0 
          AND @idCliente = NULL ) 
        BEGIN 
            INSERT @table 
            SELECT DISTINCT dbo.identificacao.nome AS "Nome", 
                            cliente.nif            AS "NIF", 
                            idcliente              AS "ID Cliente", 
                            conta.nconta           AS "Número conta", 
                            saldo                  AS "Saldo" 
            FROM   dbo.identificacao, 
                   dbo.cliente, 
                   dbo.conta 
            WHERE  nome = @Nome 
                   AND idcliente = @idCliente 
                   AND identificacao.nif = cliente.nif 
                   AND conta.nconta = cliente.nconta; 
        END 

      RETURN 
  END; 