/*Criação do database*/

CREATE DATABASE ViajeFacilDB
GO

/* Criação da tabela pais */

CREATE TABLE pais(
    id_pais BIGINT NOT NULL IDENTITY(1,1),
    nome VARCHAR(100) NOT NULL,
    CONSTRAINT PK_pais PRIMARY KEY (id_pais)
)
GO

/* Criação da tabela regiao */

CREATE TABLE regiao(
    id_regiao BIGINT NOT NULL IDENTITY(1,1),
	id_pais BIGINT NOT NULL,
    nome VARCHAR(100) NOT NULL,
    CONSTRAINT PK_regiao PRIMARY KEY (id_regiao),
	CONSTRAINT FK_regiao_pais FOREIGN KEY (id_pais) REFERENCES pais(id_pais)
)
GO

/* Criação da tabela estado */

CREATE TABLE estado(
    id_estado BIGINT NOT NULL IDENTITY(1,1),
	id_regiao BIGINT NOT NULL,
    nome VARCHAR(100) NOT NULL,
	codigouf BIGINT NULL,
	uf VARCHAR(2),
    CONSTRAINT PK_estado PRIMARY KEY (id_estado),
	CONSTRAINT FK_estado_regiao FOREIGN KEY (id_regiao) REFERENCES regiao(id_regiao)
)
GO

/* Criação da tabela cidade */

CREATE TABLE cidade(
    id_cidade BIGINT NOT NULL IDENTITY(1,1),
	id_estado BIGINT NOT NULL,
    nome VARCHAR(100) NOT NULL,
	codigo_ibge7 BIGINT NOT NULL,
	uf VARCHAR(2),
    CONSTRAINT PK_cidade PRIMARY KEY (id_cidade),
	CONSTRAINT FK_cidade_estado FOREIGN KEY (id_estado) REFERENCES estado(id_estado)
)
GO

/* Criação da tabela endereco */

CREATE TABLE endereco(
    id_endereco BIGINT NOT NULL IDENTITY(1,1),
	id_cidade BIGINT NOT NULL,
	rua VARCHAR(100) NOT NULL,
	numero INT NOT NULL,
    complemento VARCHAR(255) NULL,
	bairro VARCHAR(100) NOT NULL,
	cep VARCHAR(9) NOT NULL,
    CONSTRAINT PK_endereco PRIMARY KEY (id_endereco),
	CONSTRAINT FK_endereco_cidade FOREIGN KEY (id_cidade) REFERENCES cidade(id_cidade)
)
GO

/* Criação da tabela instituicao */

CREATE TABLE instituicao(
    id_instituicao BIGINT NOT NULL IDENTITY(1,1),
	id_endereco BIGINT NOT NULL,
    nome VARCHAR(100) NOT NULL,
	telefone VARCHAR(20) NOT NULL,
    CONSTRAINT PK_instituicao PRIMARY KEY (id_instituicao),
	CONSTRAINT FK_instituicao_endereco FOREIGN KEY (id_endereco) REFERENCES endereco(id_endereco)
)
GO

/* Criação da tabela tipo_usuario */

CREATE TABLE tipo_usuario(
    id_tipo_usuario BIGINT NOT NULL IDENTITY(1,1),
	descricao VARCHAR(255) NOT NULL,
    CONSTRAINT PK_tipo_usuario PRIMARY KEY (id_tipo_usuario)
)
GO

/* Criação da tabela usuario */

CREATE TABLE usuario(
    id_usuario BIGINT NOT NULL IDENTITY(1,1),
	id_instituicao BIGINT NOT NULL,
	id_endereco BIGINT NOT NULL,
	id_tipo_usuario BIGINT NOT NULL,
	nome VARCHAR(100) NOT NULL,
	email VARCHAR(50) NOT NULL,
	cpf VARCHAR(50) NOT NULL,
	telefone VARCHAR(20) NOT NULL,
	[login] VARCHAR(50) NOT NULL,
	senha VARCHAR(255) NOT NULL,
    CONSTRAINT PK_usuario PRIMARY KEY (id_usuario),
	CONSTRAINT FK_usuario_instituicao FOREIGN KEY (id_instituicao) REFERENCES instituicao(id_instituicao)
	CONSTRAINT FK_usuario_endereco FOREIGN KEY (id_endereco) REFERENCES endereco(id_endereco)
	CONSTRAINT FK_usuario_tipo_usuario FOREIGN KEY (id_tipo_usuario) REFERENCES tipo_usuario(id_tipo_usuario)
)
GO

/* Criação da tabela rota */

CREATE TABLE rota(
    id_rota BIGINT NOT NULL IDENTITY(1,1),
	ponto_inicial VARCHAR(255) NOT NULL,
	ponto_final VARCHAR(255) NOT NULL,
    CONSTRAINT PK_rota PRIMARY KEY (id_rota),
)
GO

/* Criação da tabela ponto_parada */

CREATE TABLE ponto_parada(
    id_ponto_parada BIGINT NOT NULL IDENTITY(1,1),
	id_rota BIGINT NOT NULL,
	descricao VARCHAR(255) NOT NULL,
	latitude VARCHAR(50) NOT NULL,
	longitude VARCHAR(50) NOT NULL,
    CONSTRAINT PK_ponto_parada PRIMARY KEY (id_ponto_parada),
	CONSTRAINT FK_ponto_parada_rota FOREIGN KEY (id_rota) REFERENCES rota(id_rota)
)
GO

/* Criação da tabela evento */

CREATE TABLE evento(
    id_evento BIGINT NOT NULL IDENTITY(1,1),
	id_instituicao BIGINT NOT NULL,
	id_endereco BIGINT NOT NULL,
	id_rota_ida BIGINT NOT NULL,
	id_rota_volta BIGINT NOT NULL,
	id_usuario_responsavel BIGINT NOT NULL,
	titulo VARCHAR(255) NOT NULL,
	descricao VARCHAR(255) NOT NULL,
	data_ida DATE NOT NULL,
	data_volta DATE NOT NULL,
    CONSTRAINT PK_evento PRIMARY KEY (id_evento),
	CONSTRAINT FK_evento_instituicao FOREIGN KEY (id_instituicao) REFERENCES instituicao(id_instituicao),
	CONSTRAINT FK_evento_endereco FOREIGN KEY (id_endereco) REFERENCES endereco(id_endereco),
	CONSTRAINT FK_evento_rota_ida FOREIGN KEY (id_rota_ida) REFERENCES rota(id_rota),
	CONSTRAINT FK_evento_rota_volta FOREIGN KEY (id_rota_volta) REFERENCES rota(id_rota),
	CONSTRAINT FK_evento_usuario_responsavel FOREIGN KEY (id_usuario_responsavel) REFERENCES usuario(id_usuario)
)
GO

/* Criação da tabela participante_evento */

CREATE TABLE participante_evento(
    id_participante_evento BIGINT NOT NULL IDENTITY(1,1),
	id_evento BIGINT NOT NULL,
	id_usuario BIGINT NOT NULL,
	pagamento INT NOT NULL,
	sugestao VARCHAR(255) NOT NULL,
	avaliacao INT NULL,
    CONSTRAINT PK_participante_evento PRIMARY KEY (id_participante_evento),
	CONSTRAINT FK_participante_evento_evento FOREIGN KEY (id_evento) REFERENCES evento(id_evento),
	CONSTRAINT FK_participante_evento_usuario FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario)
)
GO

/* Isert da tabela regiao */

INSERT INTO regiao(nome, id_pais) 
VALUES
('Norte', 30),
('Nordeste', 30),
('Centro-Oeste', 30),
('Sul', 30),
('Sudeste', 30)
GO

--SELECT * FROM regiao 


/* Isert da tabela estado */


INSERT INTO estado(uf, nome, id_regiao) VALUES
('RO', 'RONDÔNIA', 1),
('AC', 'ACRE', 1),
('AM', 'AMAZONAS', 1),
('RR', 'RORAIMA', 1),
('PA', 'PARÁ', 1),
('AP', 'AMAPÁ', 1),
('TO', 'TOCANTINS', 1),
('MA', 'MARANHÃO', 2),
('PI', 'PIAUÍ', 2),
('CE', 'CEARÁ', 2),
('RN', 'RIO GRANDE DO NORTE', 2),
('PB', 'PARAÍBA', 2),
('PE', 'PERNAMBUCO', 2),
('AL', 'ALAGOAS', 2),
('SE', 'SERGIPE', 2),
('BA', 'BAHIA', 2),
('MG', 'MINAS GERAIS', 5),
('ES', 'ESPIRITO SANTO', 5),
('RJ', 'RIO DE JANEIRO', 5),
('SP', 'SÃO PAULO', 5),
('PR', 'PARANÁ', 4),
('SC', 'SANTA CATARINA', 4),
('RS', 'RIO GRANDE DO SUL', 4),
('MS', 'MATO GROSSO DO SUL', 3),
('MT', 'MATO GROSSO', 3),
('GO', 'GOIÁS', 3),
('DF', 'DESTRITO FEDERAL', 3)


/* Isert da tabela endereco */

INSERT INTO endereco(rua, numero, complemento, cep, bairro, id_cidade) VALUES
('Abadia de Oliveira Lima', 87 , 'casa' , 79035500 ,'Alphaville' , 5118), 
('Cambacica', 74 , 'casa' , 79035505 ,'Alphaville' , 5118),
('Cotiara', 19 , 'casa' , 79035510 ,'Alphaville' , 5118),
('Coleirinha', 65 , 'casa' , 79035515 ,'Alphaville' , 5118),  
('dos Imarés', 67 , 'casa' , 79035520 ,'Alphaville' , 5118), 
('Mangona', 68 , 'casa' , 79035525 ,'Alphaville' , 5118), 
('Muriqui', 61 , 'casa' , 79035530 ,'Alphaville' , 5118), 
('Tie', 54 , 'casa' , 79035535 ,'Alphaville' , 5118), 
('Sanhaço', 48 , 'casa' , 79035540 ,'Alphaville' , 5118), 
('Tucanudo', 76 , 'casa' , 79035545 ,'Alphaville' , 5118), 
('Tsiu', 69 , 'casa' , 79035550 ,'Alphaville' , 5118), 
('Itambé', 48 , 'casa' , 79035555 ,'Alphaville' , 5118), 
('Itambé', 95 , 'casa' , 79035560 ,'Terras Alpha' , 5118), 
('Pitombeira', 86 , 'casa' , 79035562 ,'Terras Alpha' , 5118), 
('Claraíba', 85 , 'casa' , 79035564 ,'Terras Alpha' , 5118), 
('Cambroé', 62 , 'casa' , 79035566 ,'Terras Alpha' , 5118), 
('Tinguí', 73 , 'casa' , 79035568 ,'Terras Alpha' , 5118), 
('Carvoeiro', 16 , 'casa' , 79035570 ,'Terras Alpha' , 5118), 
('Kerria', 34 , 'casa' , 79035571 ,'Terras Alpha' , 5118), 
('Crindiúva', 46 , 'casa' , 79035572 ,'Terras Alpha', 5118), 
('Gravitinga', 92 , 'casa' , 79035574 ,'Terras Alpha' , 5118),
('Agerato', 76 , 'casa' , 79035576 ,'Terras Alpha' , 5118), 
('Monjoleiro', 25 , 'casa' , 79035578 ,'Terras Alpha' , 5118),
('Aurinia', 46 , 'casa' , 79035580 ,'Terras Alpha' , 5118),
('Murta', 18 , 'casa' , 79035582 ,'Terras Alpha' , 5118),
('Marolo', 27 , 'casa' , 79035584 ,'Terras Alpha' , 5118),
('Taiuva', 37 , 'casa' , 79035586 ,'Terras Alpha' , 5118),
('Siparuna', 64 , 'casa' , 79035588 ,'Terras Alpha' , 5118),
('Baliana', 38 , 'casa' , 79035590 ,'Terras Alpha' , 5118),
('Paúba', 16 , 'casa' , 79035592 ,'Terras Alpha' , 5118),
('Paina do Campo', 37 , 'casa' , 79035594 ,'Terras Alpha' , 5118),
('Passuaré', 31 , 'casa' , 79035596 ,'Terras Alpha' , 5118),
('Tucaneiro', 93 , 'casa' , 79035598 ,'Terras Alpha' , 5118),
('Vernonia', 48 , 'casa' , 79035600 ,'Terras Alpha' , 5118),
('Guaiuvira', 63 , 'casa' , 79035602 ,'Terras Alpha' , 5118),
('Gabiroba', 69 , 'casa' , 79035604 ,'Terras Alpha' , 5118),
('Veludo', 77 , 'casa' , 79035606 ,'Terras Alpha' , 5118),
('Guaraiúva', 	99 , 'casa' , 79035608 ,'Terras Alpha' , 5118)
GO

/* Isert da tabela instituicao */

INSERT INTO instituicao(nome, telefone, id_endereco) VALUES
('123 Milhas','(67) 3533-2618', 1),
('Almundo','(67) 3268-6228', 2),
('Chalinga','(67) 2215-7157', 3),
('Destinia','(67) 3151-9271', 4),
('Edestinos','(67) 2487-3751', 5),
('edreams','(67) 3258-2851', 6),
('Expedia','(67) 2632-3813', 7),
('Flightnetwork','(67) 2442-1868', 8),
('Hotel Urbano','(67) 2538-3835', 9),
('Kiwi','(67) 2932-4716', 10),
('LastMinute','(67) 3428-4392', 11),
('Luck2go','(67) 2184-2311', 12),
('MaxMilhas','(67) 2039-7827', 13),
('P2Milhas','(67) 2712-3641', 14),
('Passagens Promo','(67) 3352-3754', 15),
('Rumbo','(67) 3317-1688', 16),
('Skymilhas','(67) 2636-0310', 17),
('Submarino viagens','(67) 3055-7277', 18),
('Travel2be','(67) 2036-2202', 19),
('Viajanet','(67) 2641-1615', 20),
('Zupper','(67) 3484-7742', 21)
GO

/* Isert da tabela tipo_usuario */

INSERT INTO tipo_usuario(descricao) VALUES
 ('Cliente'), 
 ('Organizador'), 
 ('Moderador'),
 ('Administrador')
GO

/* Isert da tabela rota */


INSERT INTO rota(ponto_inicial, ponto_final) VALUES 
('Campo Grande','Ribas do Rio Pardo'),
('Ribas do Rio Pardo','Campo Grande'),
('Campo Grande','Bonito'),
('Bonito','Campo Grande'),
('Campo Grande','Amambai'),
('Amambai','Campo Grande'),
('Campo Grande','São Paulo'),
('São Paulo','Campo Grande'),
('Amambai','Florianopolis'),
('Florianopolis','Amambai')
GO

/* Isert da tabela ponto_parada */


INSERT INTO ponto_parada([id_rota], [descricao], [latitude], [longitude]) VALUES 
(1,'Chegada em Ribas do Rio Pardo','-20.4433',' 20° 26-36-Sul, 53° 45-36-Oeste'),
(2,'Chegada em Campo Grande','-20.4435',' 20° 26-37-Sul, 53° 38-47-Oeste'),
(3,'Chegada em Bonito', '-21.1313',' 21° 7-53-Sul, 56° 28-48-Oeste'),
(3,'Chegada em Campo Grande','-20.4435',' 20° 26-37-Sul, 53° 38-47-Oeste'),
(5,'Chegada em Amambai','-23.1029',' 23° 6-10-Sul, 55° 13-15-Oeste'),
(6,'Chegada em Campo Grande','-20.4435',' 20° 26-37-Sul, 53° 38-47-Oeste'),
(7,'Chegada em São Paulo','-23.5489',' 23° 32-56-Sul, 46° 38-20-Oeste'),
(8,'Chegada em Campo Grande','-20.4435',' 20° 26-37-Sul, 53° 38-47-Oeste'),
(9,'Chegada em Florianopolis','-21.1313',' 20° 26-36-Sul, 53° 45-36-Oeste'),
(10,'Chegada em Amambai','-23.1029',' 23° 6-10-Sul, 55° 13-15-Oeste')
GO

/* Isert da tabela evento */


INSERT INTO evento(titulo, descricao, data_ida, data_volta, id_instituicao, id_endereco, id_rota_ida, id_rota_volta, id_usuario_responsavel) VALUES
('Viagem','Viagem politica', '2022-09-07','2022-09-15',1,6,1,2,3),
('Viagem','Viagem Empresarial', '2022-05-04','2022-06-05',2,2,2,3,5),
('Viagem','Viagem Academica', '2022-09-10','2022-10-10',3,3,1,2,55),
('Viagem','Viagem politica', '2022-09-07','2022-09-15',4,5,3,4,299),
('Viagem','Viagem Negocios', '2022-09-15','2022-09-19',5,6,5,6,8),
('Viagem','Viagem política', '2022-06-07','2022-07-15',6,8,2,3,7),
('Viagem','Viagem Academica', '2022-12-07','2022-12-15',7,7,6,7,200),
('Viagem','Viagem Empresarial', '2022-08-07','2022-09-15',8,1,8,9,140),
('Viagem','Viagem Negocios', '2022-09-01','2022-09-19',9,3,3,4,10),
('Viagem','Viagem Academica', '2022-01-07','2022-01-15',10,6,9,10,120)
GO


/* Isert da tabela participante_evento */


INSERT INTO participante_evento(pagamento, sugestao, avaliacao, id_evento, id_usuario) VALUES
(1,'Viagem',4,10,3),
(2,'Nenhuma',5,9,5),
(3,'Hotel',5,8,55),
(4,'Tempo',4,7,299),
(5,'Valor',3,6,8),
(6,'Pagamento',5,5,7),
(7,'Viagem',4,6,200),
(8,'Horario',5,7,140),
(9,'Nenuma',4,3,10),
(10,'Nenuma',5,1,120)
GO
