# Atividade da faculdade
## *Curso: Bacharelado de Engenharia de Software*
## *Matéria: Banco de Dados*
### *Aluno: Matheus Henrique de Faria*

#### Enunciado:

* Escolher um assunto de seu interesse
* Fazer uma breve descrição do objetivo do seu banco de dados.
* Desenhar o seu banco de dados no BrModelo contendo:
    * De 5 a 10 entidades
    * Representar no diagrama apenas so atributos chaves e os mais importantes (não precisa incluir todos os atributos em cada entidade)
* Script SQL
   * Criação do banco de dados
   * Criação das entidades com seus atributos, relacionamentos, chaves e etc...
   * A inserção de dados nas tabelas, obdecendo a integridade referencial.
   * Um ou dois exemplos de atualização de dados
   * Uma consulta que traga os dados relacionando todas as entidades do seu banco de dados.

## Objetivo do banco de dados

O objetivo deste banco de dados é de trazer, de forma simplificada, o funcionamento de um estoque de um armazém. Desde o recebimento da Nota Fiscal, cadastramento do item no sistema até a expedição do pedido, com Nota Fiscal vinculada.

## Criando e inserindo valores no banco de dados

### Criando o banco de dados

```
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";
CREATE DATABASE IF NOT EXISTS `stock` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `stock`;
```

### Criando as tabelas

Tabela ITEM:

```
CREATE TABLE `item` (
  `cod_item` varchar(15) NOT NULL,
  `FK_num_nf_exp` int(11) DEFAULT NULL,
  `FK_num_pedido` varchar(20) DEFAULT NULL,
  `FK_ID_estoque` int(18) DEFAULT NULL,
  `quant_estoque` double NOT NULL,
  `data_rece` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

Tabela NFEXP_PEDIDO:

```
CREATE TABLE `nfexp_pedido` (
  `num_nf_exp` int(11) NOT NULL,
  `num_pedido` varchar(20) NOT NULL,
  `cod_item` varchar(15) NOT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

Tabela NF_EXP

```
CREATE TABLE `nf_exp` (
  `num_nf_exp` int(11) NOT NULL,
  `CFOP_exp` tinyint(4) NOT NULL,
  `remetente_exp` varchar(45) NOT NULL,
  `data_exp` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

Tabela NF_RECE

```
CREATE TABLE `nf_rece` (
  `num_nf_rece` int(9) NOT NULL,
  `FK_cod_item` varchar(15) NOT NULL,
  `id_user` int(11) NOT NULL,
  `CFOP_rece` int(4) NOT NULL,
  `remetente_rece` varchar(60) NOT NULL,
  `destinatario_rece` varchar(60) NOT NULL,
  `transportadora_rece` varchar(60) NOT NULL,
  `quant_rece` double NOT NULL,
  `data_rece` datetime NOT NULL,
  `desc_item` varchar(45) NOT NULL,
  `valor_item` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;  
```

Tabela PEDIDO

```
CREATE TABLE `pedido` (
  `num_pedido` varchar(20) NOT NULL,
  `cod_item` varchar(15) NOT NULL,
  `FK_id_user` int(11) NOT NULL,
  `quant_exp` double NOT NULL,
  `destinatario_exp` varchar(45) NOT NULL,
  `data_inclusao` datetime NOT NULL,
  `transportadora_exp` varchar(45) NOT NULL,
  `status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

Tabela POSI_ESTOQUE

```
CREATE TABLE `posi_estoque` (
  `ID_estoque` int(18) NOT NULL,
  `FK_cod_item` varchar(15) NOT NULL,
  `bloco_end` varchar(5) NOT NULL,
  `rua_end` varchar(5) NOT NULL,
  `coluna_end` varchar(5) NOT NULL,
  `andar_end` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

Tabela USUARIO

```
CREATE TABLE `usuario` (
  `id_user` int(11) NOT NULL,
  `funcao_user` varchar(25) NOT NULL,
  `nome_completo` varchar(60) NOT NULL,
  `setor` varchar(30) NOT NULL,
  `data_admissao` date NOT NULL,
  `login` varchar(10) NOT NULL,
  `senha` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

### Criando as chaves primárias (e algumas correções):

1 - Tabela ITEM
```
ALTER TABLE `item`
  ADD PRIMARY KEY (`cod_item`),
  ADD UNIQUE KEY `cod_item` (`cod_item`) USING BTREE,
  ADD KEY `FK_num_nf_exp` (`FK_num_nf_exp`),
  ADD KEY `FK_num_pedido` (`FK_num_pedido`),
  ADD KEY `FK_ID_estoque` (`FK_ID_estoque`);

```

2 - Tabela NFEXP_PEDIDO

```
ALTER TABLE `nfexp_pedido`
  ADD KEY `FOREIN KEY` (`num_nf_exp`,`num_pedido`,`cod_item`,`id_user`),
  ADD KEY `id_user` (`id_user`),
  ADD KEY `num_pedido` (`num_pedido`),
  ADD KEY `cod_item` (`cod_item`);
  
ALTER TABLE `item`
  ADD CONSTRAINT `FK_ID_estoque` FOREIGN KEY (`FK_ID_estoque`) REFERENCES `posi_estoque` (`ID_estoque`),
  ADD CONSTRAINT `FK_num_nf_exp` FOREIGN KEY (`FK_num_nf_exp`) REFERENCES `nf_exp` (`num_nf_exp`),
  ADD CONSTRAINT `FK_num_pedido` FOREIGN KEY (`FK_num_pedido`) REFERENCES `pedido` (`num_pedido`);
  
```

3 - Tabela NF_EXP

```
ALTER TABLE `nf_exp`
  ADD PRIMARY KEY (`num_nf_exp`);
```

4 - Tabela NF_RECE

```
ALTER TABLE `nf_rece`
  ADD PRIMARY KEY (`num_nf_rece`),
  ADD UNIQUE KEY `num_nf_rece` (`num_nf_rece`) USING BTREE,
  ADD KEY `cod_item` (`FK_cod_item`),
  ADD KEY `id_user` (`id_user`);
  
ALTER TABLE `nf_rece`
  ADD CONSTRAINT `cod_item` FOREIGN KEY (`FK_cod_item`) REFERENCES `item` (`cod_item`),
  ADD CONSTRAINT `id_user` FOREIGN KEY (`id_user`) REFERENCES `usuario` (`id_user`);
```

5 - Tabela PEDIDO

```
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`num_pedido`),
  ADD UNIQUE KEY `num_pedido` (`num_pedido`) USING BTREE,
  ADD UNIQUE KEY `FK_cod_item` (`cod_item`) USING BTREE,
  ADD KEY `FK_id_user` (`FK_id_user`);
  
 ALTER TABLE `pedido`
  ADD CONSTRAINT `FK_id_user` FOREIGN KEY (`FK_id_user`) REFERENCES `usuario` (`id_user`),
  ADD CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`cod_item`) REFERENCES `item` (`cod_item`);
```

6 - Tabela POSI_ESTOQUE

```
ALTER TABLE `posi_estoque`
  ADD PRIMARY KEY (`ID_estoque`),
  ADD UNIQUE KEY `ID_estoque` (`ID_estoque`) USING BTREE,
  ADD KEY `cod_item` (`FK_cod_item`) USING BTREE;
  
 ALTER TABLE `posi_estoque`
  MODIFY `ID_estoque` int(18) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10123526;
  
ALTER TABLE `posi_estoque`
  ADD CONSTRAINT `FK_cod_item` FOREIGN KEY (`FK_cod_item`) REFERENCES `item` (`cod_item`); 

```

7 - Tabela USUARIO

```
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `id_user` (`id_user`) USING BTREE;
  
ALTER TABLE `usuario`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
  
```
### Inserindo valores nas tabelas

Tabela ITEM
```
INSERT INTO `item` (`cod_item`, `FK_num_nf_exp`, `FK_num_pedido`, `FK_ID_estoque`, `quant_estoque`, `data_rece`) VALUES
('940971', 62312, '126516', 10123525, 100, '2022-05-24 00:22:01');
```

Tabela NFEXP_PEDIDO

```
INSERT INTO `nfexp_pedido` (`num_nf_exp`, `num_pedido`, `cod_item`, `id_user`) VALUES
(62312, '126516', '940971', 1);
```

Tabela NF_EXP

```
INSERT INTO `nf_exp` (`num_nf_exp`, `CFOP_exp`, `remetente_exp`, `data_exp`) VALUES
(62312, 127, 'Univille', '2022-05-10');
```

Tabela NF_RECE

```
INSERT INTO `nf_rece` (`num_nf_rece`, `FK_cod_item`, `id_user`, `CFOP_rece`, `remetente_rece`, `destinatario_rece`, `transportadora_rece`, `quant_rece`, `data_rece`, `desc_item`, `valor_item`) VALUES
(22222, '940971', 1, 5104, 'Udesc', 'Univille', 'Proprio', 100, '2022-05-24 22:06:46', 'Cadernos', 1);
```

Tabela PEDIDO

```
INSERT INTO `pedido` (`num_pedido`, `cod_item`, `FK_id_user`, `quant_exp`, `destinatario_exp`, `data_inclusao`, `transportadora_exp`, `status`) VALUES
('126516', '940971', 1, 10, 'USP', '2022-05-13 19:27:44', 'JadLog', 'Expedido');
```

Tabela POSI_ESTOQUE

```
INSERT INTO `posi_estoque` (`ID_estoque`, `FK_cod_item`, `bloco_end`, `rua_end`, `coluna_end`, `andar_end`) VALUES
(10123525, '940971', '1', '1', '1', '10');
```

Tabela USUARIO

```
INSERT INTO `usuario` (`id_user`, `funcao_user`, `nome_completo`, `setor`, `data_admissao`, `login`, `senha`) VALUES
(1, 'Admin', 'Matheus Henrique de Faria', 'CEO', '2012-05-02', 'matheusf', 'teteu123');
```


### Consultando todas as tabelas

Consultando todos as tabelas

```
SELECT `usuario`.`id_user`, `item`.`cod_item`, `nf_exp`.`num_nf_exp`, `nf_rece`.`num_nf_rece`, `pedido`.`num_pedido`, `posi_estoque`.`ID_estoque`
FROM `usuario`
	, `item` 
	LEFT JOIN `nf_exp` ON `item`.`FK_num_nf_exp` = `nf_exp`.`num_nf_exp` 
	LEFT JOIN `nf_rece` ON `nf_rece`.`FK_cod_item` = `item`.`cod_item` 
	LEFT JOIN `pedido` ON `item`.`FK_num_pedido` = `pedido`.`num_pedido` 
	LEFT JOIN `posi_estoque` ON `item`.`FK_ID_estoque` = `posi_estoque`.`ID_estoque`;
```




