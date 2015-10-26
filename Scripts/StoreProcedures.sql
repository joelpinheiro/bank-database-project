--Neste script foram criadas as stores procedures tanto para a inserção,update e delete das várias entidades existentens na nossa base de dados
SET ansi_nulls ON 

go 

SET quoted_identifier ON 

go 

--Associa  
CREATE PROCEDURE dbo.Spinsertfuncionario @NIF            INT, 
                                         --Paramentros de entrada para a criação de um funcionário, todos estes paramentros  
                                         @idfuncionario  INT, 
                                         --são obrigatorios (not null) para ser posivel criar um novo funcionário 
                                         @horarioT       VARCHAR(200), 
                                         @funcao         VARCHAR (200), 
                                         @salario        MONEY, 
                                         @balcaoTrabalho VARCHAR(100), 
                                         @nbalcao        INT 
AS 
  BEGIN 
      SET nocount ON 

      INSERT INTO dbo.funcionario 
                  --Indicação de onde se coloca os paramentros de entrada 
                  (nif, 
                   idfuncionario, 
                   horariot, 
                   funcao, 
                   salario, 
                   balcaotrabalho, 
                   nbalcao) 
      VALUES      ( @NIF, 
                    @idfuncionario, 
                    @horarioT, 
                    @funcao, 
                    @salario, 
                    @balcaoTrabalho, 
                    @nbalcao) 
  END 

SET ansi_nulls ON 

--Update Funcionario 
go 

CREATE PROCEDURE [dbo].[Spupdatefuncionario] @NIF            INT, 
                                             @idFuncionario  INT, 
                                             @horarioT       VARCHAR(200), 
                                             @funcao         VARCHAR(200), 
                                             @salario        MONEY, 
                                             @balcaoTrabalho VARCHAR(100), 
                                             @nbalcao        INT 
AS 
    UPDATE [dbo].[funcionario] 
    SET    nif = @NIF, 
           idfuncionario = @idFuncionario, 
           horariot = @horarioT, 
           funcao = @funcao, 
           salario = @salario, 
           balcaotrabalho = @balcaoTrabalho, 
           nbalcao = @nbalcao 
    WHERE  nif = @NIF 

--Associa 
go 

CREATE PROCEDURE dbo.Spinsertassocia @nConta     INT, 
                                     @idOperacao INT 
AS 
    INSERT INTO dbo.associa 
                ([nconta], 
                 [idoperacao]) 
    VALUES      (@nConta, 
                 @idOperacao) 

--Tem  
go 

CREATE PROCEDURE dbo.Spinserttem @nConta INT, 
                                 @NIF    INT 
AS 
    INSERT INTO dbo.tem 
                ([nconta], 
                 [nif]) 
    VALUES      (@nConta, 
                 @NIF) 

--SOLICITACAO  
go 

CREATE PROCEDURE dbo.Spinsertsolicitacao @idOperacao INT, 
                                         @NIF        INT 
AS 
    INSERT INTO dbo.solicitacao 
                ([idoperacao], 
                 [nif]) 
    VALUES      (@idOperacao, 
                 @NIF ) 

--OPERACAO  
go 

CREATE PROCEDURE dbo.Spinsertoperacao @idOperacao INT, 
                                      @tipo       VARCHAR(40), 
                                      @data       DATE, 
                                      @hora       TIME(7), 
                                      @NIF        INT 
AS 
    INSERT INTO dbo.operacao 
                ([idoperacao], 
                 [tipo], 
                 [data], 
                 [hora], 
                 [nif]) 
    VALUES      (@idOperacao, 
                 @tipo, 
                 @data, 
                 @hora, 
                 @NIF ) 

--DEPOSITO  
go 

CREATE PROCEDURE dbo.Spinsertdeposito @idOperacao    INT, 
                                      @idDeposito    INT, 
                                      @nconta        INT, 
                                      @valorDeposito MONEY 
AS 
    INSERT INTO dbo.deposito 
                ([idoperacao], 
                 [iddeposito], 
                 [nconta], 
                 [valordeposito]) 
    VALUES      ( @idOperacao, 
                  @idDeposito, 
                  @nconta, 
                  @valorDeposito) 

--TRANSFERENCIA  
go 

CREATE PROCEDURE dbo.Spinserttransferencia @idOperacao         INT, 
                                           @idTranferencia     INT, 
                                           @nContaOrigem       INT, 
                                           @nContaDestinatario INT, 
                                           @valorTransferencia MONEY 
AS 
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

--Conta  
go 

CREATE PROCEDURE dbo.Spinsertconta @nConta          INT, 
                                   @tipoconta       VARCHAR(100), 
                                   @balcaoAssociado VARCHAR(100), 
                                   @saldo           MONEY 
AS 
    INSERT INTO dbo.conta 
                ([nconta], 
                 [tipoconta], 
                 [balcaoassociado], 
                 [saldo]) 
    VALUES      (@nConta, 
                 @tipoconta, 
                 @balcaoAssociado, 
                 @saldo) 

go 

ALTER PROCEDURE dbo.Spupdateconta @nConta          INT, 
                                  @balcaoAssociado VARCHAR(100) 
AS 
    UPDATE dbo.conta 
    SET    balcaoassociado = @balcaoAssociado 
    WHERE  nconta = @nConta 

--LEVANTAMENTO  
go 

CREATE PROCEDURE dbo.Spinsertlevantamento @idOperacao           INT, 
                                          @idLevantamento       INT, 
                                          @montanteLevantamento MONEY, 
                                          @nConta               INT 
AS 
    INSERT INTO dbo.levantamento 
                ([idoperacao], 
                 [idlevantamento], 
                 [montantelevantamento], 
                 [nconta]) 
    VALUES      (@idOperacao, 
                 @idLevantamento, 
                 @montanteLevantamento, 
                 @nConta) 

--Deletes--------------------------------------------------------------------------------------------------------------------------------------------------------------------  
--Associa  
go 

CREATE PROCEDURE dbo.Spdeleteassocia @nConta     INT, 
                                     @idOperacao INT 
AS 
    DELETE FROM dbo.associa 
    WHERE  nconta = @nConta 
           AND idoperacao = @idOperacao 

--Tem  
go 

CREATE PROCEDURE dbo.Spdeletetem @nConta INT, 
                                 @NIF    INT 
AS 
    DELETE FROM dbo.tem 
    WHERE  nconta = @nConta 
           AND nif = @NIF 

--Conta  
go 

CREATE PROCEDURE dbo.Spdeleteconta @nConta INT 
AS 
    DELETE FROM dbo.conta 
    WHERE  nconta = @nConta 

--SOLICITACAO  
go 

CREATE PROCEDURE dbo.Spdeletesolicitacao @idOperacao INT 
AS 
    DELETE FROM dbo.solicitacao 
    WHERE  idoperacao = @idOperacao 

--OPERACAO    
go 

CREATE PROCEDURE dbo.Spdeleteoperacao @idOperacao INT 
AS 
    DELETE FROM dbo.operacao 
    WHERE  idoperacao = @idOperacao 

--DEPOSITO    
go 

CREATE PROCEDURE dbo.Spdeletedeposito @idOperacao INT 
AS 
    DELETE FROM dbo.deposito 
    WHERE  idoperacao = @idOperacao 

--TRANSFERENCIA  
go 

CREATE PROCEDURE dbo.Spdeletetransferencia @idOperacao INT 
AS 
    DELETE FROM dbo.transferencia 
    WHERE  idoperacao = @idOperacao 

--LEVANTAMENTO  
go 

CREATE PROCEDURE dbo.Spdeletelevantamento @idOperacao INT 
AS 
    DELETE FROM dbo.levantamento 
    WHERE  idoperacao = @idOperacao 

--EMPRESTIMO  
go 

CREATE PROCEDURE dbo.Spdeleteemprestimo @idOperacao INT 
AS 
    DELETE FROM dbo.emprestimo 
    WHERE  idoperacao = @idOperacao 

--------------------------------------------------------------------------------------------------------------------------------------- 
--EMPRESTIMO  
go 

CREATE PROCEDURE dbo.Spinsertemprestimo 
  -- Add the parameters for the stored procedure here  
  @idOperacao      INT, 
  @idEmprestimo    INT, 
  @taxaJuro        INT, 
  @nconta          INT, 
  @valorEmprestimo MONEY, 
  @tipoEmprestimo  VARCHAR(100) 
AS 
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

    SET ansi_nulls ON 

go 

SET quoted_identifier ON 

--Cliente 
go 

CREATE PROCEDURE dbo.Spinsertcliente @NIF                  INT, 
                                     @idCliente            INT, 
                                     @nBalcao              INT, 
                                     @nConta               INT, 
                                     @paísResidenciaFiscal VARCHAR(60), 
                                     @codReparticaoFiscal  INT, 
                                     @estadoActual         VARCHAR(60), 
                                     @profissao            VARCHAR(100), 
                                     @balcaoOrigem         VARCHAR(200), 
                                     @estadoCivil          VARCHAR (50), 
                                     @tipodocumento        VARCHAR(50), 
                                     @nIdentificacao       INT, 
                                     @paísEmissao          VARCHAR(100), 
                                     @dataEmissao          DATE 
AS 
  BEGIN 
      SET nocount ON 

      INSERT INTO dbo.cliente 
                  (nif, 
                   idcliente, 
                   nbalcao, 
                   nconta, 
                   paísresidenciafiscal, 
                   codreparticaofiscal, 
                   estadoactual, 
                   profissao, 
                   balcaoorigem, 
                   estadocivil, 
                   tipodocumento, 
                   nidentificacao, 
                   paísemissao, 
                   dataemissao) 
      VALUES      ( @NIF, 
                    @idCliente, 
                    @nBalcao, 
                    @nConta, 
                    @paísResidenciaFiscal, 
                    @codReparticaoFiscal, 
                    @estadoActual, 
                    @profissao, 
                    @balcaoOrigem, 
                    @estadoCivil, 
                    @tipodocumento, 
                    @nIdentificacao, 
                    @paísEmissao, 
                    @dataEmissao ) 
  END 

SET ansi_nulls ON 

go 

SET quoted_identifier ON 

--Balcao 
go 

CREATE PROCEDURE dbo.Spinsertbalcao @nBalcao    INT, 
                                    @ntelefone  INT, 
                                    @nome       VARCHAR(100), 
                                    @horario    VARCHAR(300), 
                                    @país       VARCHAR(100), 
                                    @localidade VARCHAR(100), 
                                    @endereco   VARCHAR(200), 
                                    @codPostal  VARCHAR(10), 
                                    @servicos   VARCHAR(200), 
                                    @fax        INT 
AS 
  BEGIN 
      SET nocount ON 

      INSERT INTO dbo.balcao 
                  (nbalcao, 
                   ntelefone, 
                   nome, 
                   horario, 
                   país, 
                   localidade, 
                   endereco, 
                   codpostal, 
                   servicos, 
                   fax) 
      VALUES      ( @nBalcao, 
                    @ntelefone, 
                    @nome, 
                    @horario, 
                    @país, 
                    @localidade, 
                    @endereco, 
                    @codPostal, 
                    @servicos, 
                    @fax ) 
  END 

SET ansi_nulls ON 

go 

SET quoted_identifier ON 

--Identificação 
go 

ALTER PROCEDURE dbo.Spinsertidentificacao @NIF            INT, 
                                          @nTelefone      INT, 
                                          @nome           VARCHAR(100), 
                                          @dataNascimento DATE, 
                                          @país           VARCHAR(60), 
                                          @localidade     VARCHAR(100), 
                                          @endereco       VARCHAR(200), 
                                          @codPostal      VARCHAR(10), 
                                          @gênero         CHAR(1), 
                                          @idade          INT 
AS 
  BEGIN 
      SET nocount ON 

      INSERT INTO dbo.identificacao 
                  (nif, 
                   ntelefone, 
                   nome, 
                   datanascimento, 
                   país, 
                   localidade, 
                   endereco, 
                   codpostal, 
                   gênero, 
                   idade) 
      VALUES      ( @NIF, 
                    @nTelefone, 
                    @nome, 
                    @dataNascimento, 
                    @país, 
                    @localidade, 
                    @endereco, 
                    @codPostal, 
                    @gênero, 
                    @idade ) 
  END 

--Update Cliente 
go 

CREATE PROCEDURE [dbo].[Spupdatecliente] @NIF                  INT, 
                                         @idCliente            INT, 
                                         @nBalcao              INT, 
                                         @nConta               INT, 
                                         @paísResidenciaFiscal VARCHAR(60), 
                                         @codReparticaoFiscal  INT, 
                                         @estadoActual         VARCHAR(60), 
                                         @profissao            VARCHAR(100), 
                                         @balcaoOrigem         VARCHAR(200), 
                                         @estadoCivil          VARCHAR (50), 
                                         @tipodocumento        VARCHAR(50), 
                                         @nIdentificacao       INT, 
                                         @paísEmissao          VARCHAR(100), 
                                         @dataEmissao          DATE 
AS 
    UPDATE [dbo].[cliente] 
    SET    nif = @NIF, 
           idcliente = @idCliente, 
           nbalcao = @nBalcao, 
           nconta = @nConta, 
           paísresidenciafiscal = @paísResidenciaFiscal, 
           codreparticaofiscal = @codReparticaoFiscal, 
           estadoactual = @estadoActual, 
           profissao = @profissao, 
           balcaoorigem = @balcaoOrigem, 
           estadocivil = @estadoCivil, 
           tipodocumento = @tipodocumento, 
           nidentificacao = @nIdentificacao, 
           paísemissao = @paísEmissao, 
           dataemissao = @dataEmissao 
    WHERE  nif = @NIF 

--Update Balcao 
go 

CREATE PROCEDURE [dbo].[Spupdatebalcao] @nBalcao    INT, 
                                        @ntelefone  INT, 
                                        @nome       VARCHAR(100), 
                                        @horario    VARCHAR(300), 
                                        @país       VARCHAR(100), 
                                        @localidade VARCHAR(100), 
                                        @endereco   VARCHAR(200), 
                                        @codPostal  VARCHAR(10), 
                                        @servicos   VARCHAR(200), 
                                        @fax        INT 
AS 
    UPDATE [dbo].[balcao] 
    SET    nbalcao = @nBalcao, 
           ntelefone = @ntelefone, 
           nome = @nome, 
           horario = @horario, 
           país = @país, 
           localidade = @localidade, 
           endereco = @endereco, 
           codpostal = @codPostal, 
           servicos = @servicos, 
           fax = @fax 
    WHERE  nbalcao = @nBalcao 

--Update identificação 
go 

CREATE PROCEDURE [dbo].[Spupdateidentificacao] @NIF            INT, 
                                               @nTelefone      INT, 
                                               @nome           VARCHAR(100), 
                                               @dataNascimento DATE, 
                                               @país           VARCHAR(60), 
                                               @localidade     VARCHAR(100), 
                                               @endereco       VARCHAR(200), 
                                               @codPostal      VARCHAR(10), 
                                               @gênero         CHAR(1), 
                                               @idade          INT 
AS 
    UPDATE [dbo].[identificacao] 
    SET    ntelefone = @nTelefone, 
           nome = @nome, 
           datanascimento = @dataNascimento, 
           país = @país, 
           localidade = @localidade, 
           endereco = @endereco, 
           codpostal = @codPostal, 
           gênero = @gênero, 
           idade = @idade 
    WHERE  nif = @NIF 

--Delete Cliente 
go 

CREATE PROCEDURE [dbo].[Deletecliente] @NIF INT 
AS 
    DELETE FROM cliente 
    WHERE  nif = @NIF 

--Delete funcionario 
go 

CREATE PROCEDURE [dbo].[Deletefuncionario] @NIF INT 
AS 
    DELETE FROM funcionario 
    WHERE  nif = @NIF 

--Delete Balcao 
go 

CREATE PROCEDURE [dbo].[Deletebalcao] @nBalcao INT 
AS 
    DELETE FROM balcao 
    WHERE  nbalcao = @nBalcao 

--Delete identificacao 
go 

CREATE PROCEDURE [dbo].[Deleteidentificacao] @NIF INT 
AS 
    DELETE FROM cliente 
    WHERE  nif = @NIF 