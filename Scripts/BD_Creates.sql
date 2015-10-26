CREATE TABLE identificacao 
  ( 
     nif            INT NOT NULL, 
     ntelefone      INT NOT NULL, 
     nome           VARCHAR(100) NOT NULL, 
     datanascimento DATE NOT NULL, 
     país           VARCHAR(60) NOT NULL, 
     localidade     VARCHAR(100) NOT NULL, 
     endereco       VARCHAR(200) NOT NULL, 
     codpostal      VARCHAR(10) NOT NULL, 
     gênero         CHAR(1) NOT NULL, 
     idade          INT NOT NULL, 
     PRIMARY KEY (nif) 
  ); 

CREATE TABLE balcao 
  ( 
     nbalcao    INT NOT NULL, 
     ntelefone  INT, 
     nome       VARCHAR(100) NOT NULL, 
     horario    VARCHAR(300) NOT NULL, 
     país       VARCHAR(100) NOT NULL, 
     localidade VARCHAR(100) NOT NULL, 
     endereco   VARCHAR(200) NOT NULL, 
     codpostal  VARCHAR(10) NOT NULL, 
     servicos   VARCHAR(200), 
     fax        INT, 
     PRIMARY KEY (nbalcao) 
  ); 

CREATE TABLE cliente 
  ( 
     nif                  INT UNIQUE NOT NULL, 
     idcliente            INT NOT NULL, 
     nbalcao              INT NOT NULL, 
     nconta               INT NOT NULL, 
     paísresidenciafiscal VARCHAR(60) NOT NULL, 
     codreparticaofiscal  INT NOT NULL, 
     estadoactual         VARCHAR(60) NOT NULL, 
     profissao            VARCHAR(100), 
     balcaoorigem         VARCHAR(200) NOT NULL, 
     estadocivil          VARCHAR (50), 
     tipodocumento        VARCHAR(50) NOT NULL, 
     nidentificacao       INT NOT NULL, 
     paísemissao          VARCHAR(100) NOT NULL, 
     dataemissao          DATE NOT NULL, 
     PRIMARY KEY (nif, idcliente) 
  ); 

CREATE TABLE funcionario 
  ( 
     nif            INT UNIQUE NOT NULL, 
     idfuncionario  INT NOT NULL, 
     horariot       VARCHAR(200) NOT NULL, 
     funcao         VARCHAR(200) NOT NULL, 
     salario        MONEY NOT NULL, 
     balcaotrabalho VARCHAR(100) NOT NULL, 
     nbalcao        INT NOT NULL, 
     PRIMARY KEY (nif, idfuncionario) 
  ); 

CREATE TABLE transferencia 
  ( 
     idoperacao         INT NOT NULL, 
     idtranferencia     INT NOT NULL, 
     ncontaorigem       INT NOT NULL, 
     ncontadestinatario INT NOT NULL, 
     valortransferencia MONEY NOT NULL, 
     PRIMARY KEY (idoperacao) 
  ); 

CREATE TABLE levantamento 
  ( 
     idoperacao           INT NOT NULL, 
     idlevantamento       INT NOT NULL, 
     montantelevantamento MONEY NOT NULL, 
     nconta               INT NOT NULL, 
     PRIMARY KEY (idoperacao) 
  ); 

CREATE TABLE emprestimo 
  ( 
     idoperacao      INT NOT NULL, 
     idemprestimo    INT NOT NULL, 
     taxajuro        INT NOT NULL, 
     nconta          INT NOT NULL, 
     valoremprestimo MONEY NOT NULL, 
     tipoemprestimo  VARCHAR(100) NOT NULL, 
     PRIMARY KEY (idoperacao) 
  ); 

CREATE TABLE conta 
  ( 
     nconta          INT NOT NULL, 
     tipoconta       VARCHAR(100) NOT NULL, 
     balcaoassociado VARCHAR(100) NOT NULL, 
     saldo           MONEY NOT NULL, 
     PRIMARY KEY (nconta) 
  ); 

CREATE TABLE operacao 
  ( 
     idoperacao INT NOT NULL, 
     tipo       VARCHAR(40) NOT NULL, 
     data       DATE NOT NULL, 
     hora       TIME NOT NULL, 
     nif        INT NOT NULL, 
     PRIMARY KEY (idoperacao) 
  ); 

CREATE TABLE solicitacao 
  ( 
     idoperacao INT NOT NULL, 
     nif        INT NOT NULL, 
     PRIMARY KEY (idoperacao, nif) 
  ); 

CREATE TABLE deposito 
  ( 
     idoperacao    INT NOT NULL, 
     iddeposito    INT NOT NULL, 
     nconta        INT NOT NULL, 
     valordeposito MONEY NOT NULL, 
     PRIMARY KEY (idoperacao) 
  ); 

CREATE TABLE associa 
  ( 
     nconta     INT NOT NULL, 
     idoperacao INT NOT NULL, 
     PRIMARY KEY (nconta, idoperacao) 
  ); 

CREATE TABLE tem 
  ( 
     nconta INT NOT NULL, 
     nif    INT NOT NULL, 
     PRIMARY KEY (nconta, nif) 
  ); 

ALTER TABLE cliente 
  ADD CONSTRAINT fobalcaonbalcao FOREIGN KEY (nbalcao) REFERENCES balcao(nbalcao 
  ); 

ALTER TABLE cliente 
  ADD CONSTRAINT foclienteiden FOREIGN KEY (nif) REFERENCES identificacao(nif); 

ALTER TABLE funcionario 
  ADD CONSTRAINT fofuncionaiden FOREIGN KEY (nif) REFERENCES identificacao(nif); 

ALTER TABLE operacao 
  ADD CONSTRAINT foopnif FOREIGN KEY (nif) REFERENCES funcionario(nif); 

ALTER TABLE funcionario 
  ADD CONSTRAINT fofunnbalcao FOREIGN KEY (nbalcao) REFERENCES balcao(nbalcao); 

ALTER TABLE solicitacao 
  ADD CONSTRAINT solicitacaooperacaoidop FOREIGN KEY (idoperacao) REFERENCES 
  operacao(idoperacao); 

ALTER TABLE solicitacao 
  ADD CONSTRAINT solicitacaooperacaonif FOREIGN KEY (nif) REFERENCES cliente(nif 
  ); 

ALTER TABLE tem 
  ADD CONSTRAINT temclientenif FOREIGN KEY (nif) REFERENCES cliente(nif); 

ALTER TABLE tem 
  ADD CONSTRAINT temcontanconta FOREIGN KEY (nconta) REFERENCES conta(nconta); 

ALTER TABLE associa 
  ADD CONSTRAINT associacontanconta FOREIGN KEY (nconta) REFERENCES conta(nconta 
  ); 

ALTER TABLE associa 
  ADD CONSTRAINT associaoperacaoidop FOREIGN KEY (idoperacao) REFERENCES 
  operacao(idoperacao); 

ALTER TABLE emprestimo 
  ADD CONSTRAINT emprestimooperacaoidop FOREIGN KEY (idoperacao) REFERENCES 
  operacao(idoperacao); 

ALTER TABLE levantamento 
  ADD CONSTRAINT levantamentooperacaoidop FOREIGN KEY (idoperacao) REFERENCES 
  operacao(idoperacao); 

ALTER TABLE transferencia 
  ADD CONSTRAINT transferenciaoperacaoidop FOREIGN KEY (idoperacao) REFERENCES 
  operacao(idoperacao); 

ALTER TABLE deposito 
  ADD CONSTRAINT depositooperacaoidop FOREIGN KEY (idoperacao) REFERENCES 
  operacao(idoperacao); 