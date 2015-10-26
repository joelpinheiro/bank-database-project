-- Uma vez que é frequentemente utilizado nas cláusulas WHERE o número de conta, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela emprestimo, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexemprestimonconta 
  ON dbo.emprestimo(nconta) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE o ID do empréstimo, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela emprestimo, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
CREATE NONCLUSTERED INDEX indexemprestimoid 
  ON dbo.emprestimo(idemprestimo) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE o número de conta, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela levantamento, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexlevantamentonconta 
  ON dbo.levantamento(nconta) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE o ID do levantamento, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela levantamento, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
CREATE NONCLUSTERED INDEX indexlevantamentoid 
  ON dbo.levantamento(idlevantamento) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE o ID da transferência, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela transferência, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indextransferenciaid 
  ON dbo.transferencia(idtranferencia) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE o número de conta origem, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela transferência, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
CREATE NONCLUSTERED INDEX indextransferenciacontao 
  ON dbo.transferencia(ncontaorigem) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE o número de conta destinatário, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela transferência, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
CREATE NONCLUSTERED INDEX indextransferenciacontad 
  ON dbo.transferencia(ncontadestinatario) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE o número de conta, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela depósito, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexdepositonconta 
  ON dbo.deposito(nconta) 
  WITH (FILLFACTOR=75, pad_index=ON); 

---------- IDENTIFICACAO ----------------  
-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura por nome, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexnomeident 
  ON dbo.identificacao (nome) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura por CodPostal, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexcodpostalident 
  ON dbo.identificacao (codpostal) 
  WITH (FILLFACTOR=75, pad_index=ON); 

---------- BALCAO ----------------  
-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura por nome do balcão, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexnomebalcao 
  ON dbo.balcao (nome) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura por nome do balcão, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexcodpostalbalcao 
  ON dbo.balcao (codpostal) 
  WITH (FILLFACTOR=75, pad_index=ON); 

---------- CLIENTE ----------------  
-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura por número de conta, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexnumcontacliente 
  ON dbo.cliente (nconta) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura por balcão origem, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexbalcaoorigemcliente 
  ON dbo.cliente (balcaoorigem) 
  WITH (FILLFACTOR=75, pad_index=ON); 

---------- CONTA ----------------  
-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura por tipo de conta, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indextipoconta 
  ON dbo.conta (tipoconta) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura saldo, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexsaldoconta 
  ON dbo.conta (saldo) 
  WITH (FILLFACTOR=75, pad_index=ON); 

---------- FUNCIONARIO ----------------  
-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a procura por função, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexfuncaofuncionario 
  ON dbo.funcionario (funcao) 
  WITH (FILLFACTOR=75, pad_index=ON); 

-- Uma vez que é frequentemente utilizado nas cláusulas WHERE a balcão de trabalho, este atributo deve ser um índice
-- Como já existe um índice do tipo CLUSTERED na tabela identificacao, este tem obrigatóriamente de ser do tipo NONCLUSTER
-- Porque não tem ordem natural e pode ser inserido em qualquer parte da b-tree, serão inseridos os filtos FILLFACTOR e PAD_INDEX  
go 

CREATE NONCLUSTERED INDEX indexbalcaotrabalhofuncionario 
  ON dbo.funcionario (balcaotrabalho) 
  WITH (FILLFACTOR=75, pad_index=ON); 