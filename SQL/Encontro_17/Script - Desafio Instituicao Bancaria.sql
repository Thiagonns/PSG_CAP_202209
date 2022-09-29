CREATE TABLE InstituicaoBancaria(
InstituicaoBancariaID INT NOT NULL IDENTITY(1,1),
CodigoBanco INT NULL,
Descricao VARCHAR(MAX) NOT NULL,
SiteWWW VARCHAR(MAX) NOT NULL,
DataInsert DATETIME NULL DEFAULT GETDATE(),
CONSTRAINT PK_InstituicaoBancaria PRIMARY KEY (InstituicaoBancariaID)
)
GO


SET IDENTITY_INSERT [dbo].[InstituicaoBancaria] ON

INSERT INTO [dbo].[InstituicaoBancaria] ([InstituicaoBancariaID], [CodigoBanco], [Descricao], [SiteWWW]) VALUES
 (1, 246, 'Banco ABC Brasil S.A. ', 'http://www.abcbrasil.com.br/ '), 
 (2, 356, 'Banco ABN AMRO Real S.A. ', 'http://www.abnamro.com.br/ '), 
 (3, 25, 'Banco Alfa S.A. ', 'http://www.bancoalfa.com.br/ '), 
 (4, 641, 'Banco Alvorada S.A. ', 'N�o possui site '), 
 (5, NULL, 'Banco American Express S.A. ', 'http://www.aexp.com/ '), 
 (6, 29, 'Banco Banerj S.A. ', 'http://www.banerj.com.br/ '), 
 (7, 38, 'Banco Banestado S.A. ', 'http://www.banestado.com.br/ '), 
 (8, 740, 'Banco Barclays S.A. ', 'http://www.barclays.com/ '), 
 (9, 107, 'Banco BBM S.A. ', 'http://www.bbmbank.com.br/ '), 
 (10, 31, 'Banco Beg S.A. ', 'http://www.itau.com.br/ '), 
 (11, 36, 'Banco Bem S.A. ', 'N�o possui site '), 
 (12, 394, 'Banco BMC S.A. ', 'http://www.bmc.com.br/ '), 
 (13, 318, 'Banco BMG S.A. ', 'http://www.bancobmg.com.br/ '), 
 (14, 752, 'Banco BNP Paribas Brasil S.A. ', 'http://www.bnpparibas.com.br/ '), 
 (15, 248, 'Banco Boavista Interatl�ntico S.A. ', 'n�o possui site '), 
 (16, 237, 'Banco Bradesco S.A. ', 'http://www.bradesco.com.br/ '), 
 (17, 225, 'Banco Brascan S.A. ', 'http://www.bancobrascan.com.br/ '), 
 (18, 263, 'Banco Cacique S.A. ', 'http://www.bancocacique.com.br/ '), 
 (19, 222, 'Banco Calyon Brasil S.A. ', 'http://www.calyon.com.br/ '), 
 (20, 40, 'Banco Cargill S.A. ', 'http://www.bancocargill.com.br/ '), 
 (21, 745, 'Banco Citibank S.A. ', 'http://www.citibank.com/brasil '), 
 (22, 215, 'Banco Comercial e de Investimento Sudameris S.A. ', 'N�o possui site'), 
 (23, 756, 'Banco Cooperativo do Brasil S.A. - BANCOOB ', 'http://www.bancoob.com.br/ '), 
 (24, 748, 'Banco Cooperativo Sicredi S.A. - BANSICREDI ', 'http://www.bansicredi.com.br/ '), 
 (25, 505, 'Banco Credit Suisse (Brasil) S.A. ', 'http://www.csfb.com/ '), 
 (26, 229, 'Banco Cruzeiro do Sul S.A. ', 'http://www.bcsul.com.br/ '), 
 (27, 3, 'Banco da Amaz�nia S.A. ', 'http://www.bancoamazonia.com.br/ '), 
 (28, 707, 'Banco Daycoval S.A. ', 'http://www.daycoval.com.br/ '), 
 (29, NULL, 'Banco de Lage Landen Brasil S.A. ', 'http://www.delagelanden.com/ '), 
 (30, 24, 'Banco de Pernambuco S.A. - BANDEPE ', 'http://www.bandepe.com.br/ '), 
 (31, 456, 'Banco de Tokyo-Mitsubishi Brasil S.A. ', 'http://www.btm.com.br/ '), 
 (32, 214, 'Banco Dibens S.A. ', 'http://www.bancodibens.com.br/ '), 
 (33, 1, 'Banco do Brasil S.A. ', 'http://www.bb.com.br/ '), 
 (34, 27, 'Banco do Estado de Santa Catarina S.A. ', 'http://www.besc.com.br/ '), 
 (35, 33, 'Banco do Estado de S�o Paulo S.A. - Banespa ', 'http://www.banespa.com.br/ '), 
 (36, 47, 'Banco do Estado de Sergipe S.A. ', 'http://www.banese.com.br/ '), 
 (37, 37, 'Banco do Estado do Par� S.A. ', 'http://www.banparanet.com.br/ '), 
 (38, 41, 'Banco do Estado do Rio Grande do Sul S.A. ', 'http://www.banrisul.com.br/ '), 
 (39, 4, 'Banco do Nordeste do Brasil S.A. ', 'http://www.banconordeste.gov.br/ '), 
 (40, 265, 'Banco Fator S.A. ', 'http://www.bancofator.com.br/ '), 
 (41, NULL, 'Banco Fiat S.A. ', 'http://www.bancofiat.com.br/ '), 
 (42, 224, 'Banco Fibra S.A. ', 'http://www.bancofibra.com.br/ '), 
 (43, 175, 'Banco Finasa S.A. ', 'n�o possui site '), 
 (44, 252, 'Banco Fininvest S.A. ', 'http://www.fininvest.com.br/ '), 
 (45, 233, 'Banco GE Capital S.A. ', 'http://www.bancoge.com.br/ '), 
 (46, NULL, 'Banco General Motors S.A. ', 'http://www.bancogm.com.br/ '), 
 (47, 734, 'Banco Gerdau S.A. ', 'http://www.bancogerdau.com.br/ '), 
 (48, 612, 'Banco Guanabara S.A. ', 'n�o possui site '), 
 (49, 63, 'Banco Ibi S.A. Banco M�ltiplo ', 'N�o possui site '), 
 (50, 604, 'Banco Industrial do Brasil S.A. ', 'http://www.bancoindustrial.com.br/ '), 
 (51, 320, 'Banco Industrial e Comercial S.A. ', 'http://www.bicbanco.com.br/ '), 
 (52, 653, 'Banco Indusval S.A. ', 'http://www.indusval.com.br/ '), 
 (53, 630, 'Banco Intercap S.A. ', 'http://www.intercap.com.br/ '), 
 (54, 249, 'Banco Investcred Unibanco S.A. ', 'N�o possui site '), 
 (55, 48, 'Banco Ita� BBA S.A. ', 'http://www.itaubba.com.br/ '), 
 (56, 652, 'Banco Ita� Holding Financeira S.A. ', 'http://www.itau.com.br/ '), 
 (57, 341, 'Banco Ita� S.A. ', 'http://www.itau.com.br/ '), 
 (58, NULL, 'Banco Itaucred Financiamentos S.A. ', 'http://www.itaucred.com.br/ '), 
 (59, NULL, 'Banco Itausaga S.A. ', 'http://www.itau.com.br/ '), 
 (60, 376, 'Banco J. P. Morgan S.A. ', 'http://www.jpmorgan.com/ '), 
 (61, 74, 'Banco J. Safra S.A. ', 'http://www.jsafra.com.br/ '), 
 (62, 757, 'Banco KEB do Brasil S.A. ', 'n�o possui site '), 
 (63, 600, 'Banco Luso Brasileiro S.A. ', 'http://www.lusobrasileiro.com.br/ '), 
 (64, 392, 'Banco Mercantil de S�o Paulo S.A. ', 'n�o possui site '), 
 (65, 389, 'Banco Mercantil do Brasil S.A. ', 'http://www.mercantil.com.br/ '), 
 (66, 755, 'Banco Merrill Lynch de Investimentos S.A. ', 'http://www.ml.com/ '), 
 (67, 151, 'Banco Nossa Caixa S.A. ', 'http://www.nossacaixa.com.br/ '), 
 (68, 45, 'Banco Opportunity S.A. ', 'http://www.opportunity.com.br/ '), 
 (69, 208, 'Banco Pactual S.A. ', 'http://www.pactual.com.br/ '), 
 (70, 623, 'Banco Panamericano S.A. ', 'http://www.panamericano.com.br/ '), 
 (71, 611, 'Banco Paulista S.A. ', 'http://www.bancopaulista.com.br/ '), 
 (72, 643, 'Banco Pine S.A. ', 'http://www.bancopine.com.br/ '), 
 (73, 638, 'Banco Prosper S.A. ', 'http://www.bancoprosper.com.br/ '), 
 (74, 747, 'Banco Rabobank International Brasil S.A. ', 'http://www.rabobank.com/ '), 
 (75, 633, 'Banco Rendimento S.A. ', 'http://www.rendimento.com.br/ '), 
 (76, 72, 'Banco Rural Mais S.A. ', 'http://www.rural.com.br/ '), 
 (77, 453, 'Banco Rural S.A. ', 'http://www.rural.com.br/ '), 
 (78, 422, 'Banco Safra S.A. ', 'http://www.safra.com.br/ '), 
 (79, 353, 'Banco Santander Brasil S.A. ', 'http://www.santander.com.br/ '), 
 (80, 8, 'Banco Santander Meridional S.A. ', 'http://www.meridional.com.br/ '), 
 (81, 351, 'Banco Santander S.A. ', 'http://www.santander.com.br/ '), 
 (82, 250, 'Banco Schahin S.A. ', 'http://www.bancoschahin.com.br/ '), 
 (83, 749, 'Banco Simples S.A. ', 'http://www.bancosimples.com.br/ '), 
 (84, 366, 'Banco Soci�t� G�n�rale Brasil S.A. ', 'http://www.sgbrasil.com.br/ '), 
 (85, 637, 'Banco Sofisa S.A. ', 'http://www.sofisa.com.br/ '), 
 (86, 347, 'Banco Sudameris Brasil S.A. ', 'http://www.sudameris.com.br/ '), 
 (87, 464, 'Banco Sumitomo Mitsui Brasileiro S.A. ', 'http://n�o%20possue%20site/ '), 
 (88, 634, 'Banco Tri�ngulo S.A. ', 'http://www.tribanco.com.br/ '), 
 (89, 247, 'Banco UBS S.A. ', 'http://www.ubsw.com/ '), 
 (90, 116, 'Banco �nico S.A. ', 'http://www.unibanco.com.br/ '), 
 (91, 655, 'Banco Votorantim S.A. ', 'http://www.bancovotorantim.com.br/ '), 
 (92, 610, 'Banco VR S.A. ', 'http://www.vr.com.br/ '), 
 (93, 370, 'Banco WestLB do Brasil S.A. ', 'http://www.westlb.com.br/ '), 
 (94, 21, 'BANESTES S.A. Banco do Estado do Esp�rito Santo ', 'http://www.banestes.com.br/ '), 
 (95, 719, 'Banif-Banco Internacional do Funchal (Brasil)S.A. ', 'http://www.banif.com.br/ '), 
 (96, 479, 'BankBoston Banco M�ltiplo S.A. ', 'http://www.bankboston.com.br/ '), 
 (97, 744, 'BankBoston N.A. ', 'http://www.bankboston.com.br/ '), 
 (98, NULL, 'BB Banco Popular do Brasil S.A. ', 'http://www.bancopopulardobrasil.com.br/ '), 
 (99, NULL, 'BES Investimento do Brasil S.A.-Banco de Investimento ', 'http://www.besinvestimento.com.br/ '), 
 (100, 70, 'BRB - Banco de Bras�lia S.A. ', 'http://www.brb.com.br/ '), 
 (101, 104, 'Caixa Econ�mica Federal ', 'http://www.caixa.gov.br/ '), 
 (102, 477, 'Citibank N.A. ', 'http://www.citibank.com/brasil '), 
 (103, NULL, 'Credicard Banco S.A. ', 'N�o possui site '), 
 (104, 487, 'Deutsche Bank S.A. - Banco Alem�o ', 'http://www.deutsche-bank.com.br/ '), 
 (105, 751, 'Dresdner Bank Brasil S.A. - Banco M�ltiplo ', 'http://www.drkw.net/ '), 
 (106, 210, 'Dresdner Bank Lateinamerika Aktiengesellschaft ', 'http://www.dbla.com/ '), 
 (107, 62, 'Hipercard Banco M�ltiplo S.A. ', 'http://www.banco1.net/ '), 
 (108, 399, 'HSBC Bank Brasil S.A. - Banco M�ltiplo ', 'http://www.hsbc.com.br/ '), 
 (109, 492, 'ING Bank N.V. ', 'http://www.ing.com/ '), 
 (110, 488, 'JPMorgan Chase Bank ', 'http://www.jpmorganchase.com/ '), 
 (111, 65, 'Lemon Bank Banco M�ltiplo S.A. ', 'http://www.lemon.com/ '), 
 (112, 409, 'UNIBANCO - Uni�o de Bancos Brasileiros S.A. ', 'http://www.unibanco.com.br/ '), 
 (113, 230, 'Unicard Banco M�ltiplo S.A. ', 'http://www.unicard.com.br/ '), 
 (117, 654, 'Banco A.J.Renner S.A. ', 'http://www.bancorenner.com.br/ '), 
 (118, 213, 'Banco Arbi S.A. ', 'http://www.arbi.com.br/ '), 
 (119, 739, 'Banco BGN S.A. ', 'http://www.bgn.com.br/ '), 
 (120, 96, 'Banco BM&F de Servi�os de Liquida��o e Cust�dia S.A ', 'http://www.bmf.com.br/ '), 
 (121, 218, 'Banco Bonsucesso S.A. ', 'http://www.bancobonsucesso.com.br/ '), 
 (122, NULL, 'Banco BRJ S.A. ', 'http://www.brjbank.com.br/ '), 
 (123, 44, 'Banco BVA S.A. ', 'http://www.bancobva.com.br/ '), 
 (124, 412, 'Banco Capital S.A. ', 'http://www.bancocapital.com.br/ '), 
 (125, 266, 'Banco C�dula S.A. ', 'http://www.bancocedula.com.br/ '), 
 (126, 241, 'Banco Cl�ssico S.A. ', 'N�o possui site '), 
 (127, NULL, 'Banco CNH Capital S.A. ', 'http://www.bancocnh.com.br/ '), 
 (128, 753, 'Banco Comercial Uruguai S.A. ', 'http://www.bancocomercial.com.br/ '), 
 (129, 75, 'Banco CR2 S.A. ', 'N�o possui site'), 
 (130, 721, 'Banco Credibel S.A. ', 'http://www.credibel.com.br/ '), 
 (131, NULL, 'Banco Daimlerchrysler S.A. ', 'http://www.bancodaimlerchrysler.com.br/ '), 
 (132, 300, 'Banco de La Nacion Argentina ', 'http://www.bna.com.ar/ '), 
 (133, 495, 'Banco de La Provincia de Buenos Aires ', 'http://www.bapro.com.ar/ '), 
 (134, 494, 'Banco de La Republica Oriental del Uruguay ', 'N�o possui site '), 
 (135, 35, 'Banco do Estado do Cear� S.A. - BEC ', 'http://www.bec.com.br/ '), 
 (136, 39, 'Banco do Estado do Piau� S.A. - BEP ', 'http://www.bep.com.br/ '), 
 (137, 743, 'Banco Emblema S.A. ', 'http://www.bancoemblema.com.br/ '), 
 (138, 626, 'Banco Ficsa S.A. ', 'http://www.ficsa.com.br/ '), 
 (139, NULL, 'Banco Ford S.A. ', 'http://www.bancoford.com.br/ '), 
 (140, NULL, 'Banco Honda S.A. ', 'http://www.bancohonda.com.br/ '), 
 (141, NULL, 'Banco IBM S.A. ', 'http://www.ibm.com/br/financing/ '), 
 (142, 217, 'Banco John Deere S.A. ', 'http://www.johndeere.com.br/ '), 
 (143, 212, 'Banco Matone S.A. ', 'http://www.bancomatone.com.br/ '), 
 (144, 243, 'Banco M�xima S.A. ', 'http://www.bancomaxima.com.br/ '), 
 (145, NULL, 'Banco Maxinvest S.A. ', 'N�o possui site '), 
 (146, 746, 'Banco Modal S.A. ', 'http://www.bancomodal.com.br/ '), 
 (147, NULL, 'Banco Moneo S.A. ', 'N�o possui site '), 
 (148, 738, 'Banco Morada S.A. ', 'http://www.bancomorada.com.br/ '), 
 (149, 66, 'Banco Morgan Stanley Dean Witter S.A. ', 'http://www.morganstanley.com.br/ '), 
 (150, NULL, 'Banco Ourinvest S.A. ', 'http://www.ourinvest.com.br/ '), 
 (151, 613, 'Banco Pec�nia S.A. ', 'http://www.bancopecunia.com.br/ '), 
 (152, 724, 'Banco Porto Seguro S.A. ', 'N�o possui site '), 
 (153, 735, 'Banco Pottencial S.A. ', 'http://www.pottencial.com.br/ '), 
 (154, NULL, 'Banco PSA Finance Brasil S.A. ', 'N�o possui site '), 
 (155, 741, 'Banco Ribeir�o Preto S.A. ', 'http://www.brp.com.br/ '), 
 (156, NULL, 'Banco Rodobens S.A. ', 'http://www.rodobens.com.br/ '), 
 (157, NULL, 'Banco Toyota do Brasil S.A. ', 'http://www.bancotoyota.com.br/ '), 
 (158, NULL, 'Banco Tricury S.A. ', 'http://www.tricury.com.br/ '), 
 (159, NULL, 'Banco Volkswagen S.A. ', 'http://www.bancovw.com.br/ '), 
 (160, NULL, 'Banco Volvo (Brasil) S.A. ', 'N�o possui site '), 
 (161, NULL, 'BPN Brasil Banco M�tiplo S.A. ', 'N�o possui site '), 
 (162, 64, 'Goldman Sachs do Brasil Banco M�ltiplo S.A. ', 'http://www.goldmansachs.com/ '), 
 (163, 254, 'Paran� Banco S.A. ', 'http://www.paranabanco.com.br/ ')
 GO

SET IDENTITY_INSERT [dbo].[InstituicaoBancaria] OFF

