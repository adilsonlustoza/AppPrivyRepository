using AppPrivy.InfraStructure.Contexto;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.ObjectValue;
using System;
using System.Collections.Generic;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class DoacaoMaisDBInitializer 
    {
        public static void Seed(AppPrivyContext context)
        {
            var defaultCaccc = new List<Caccc>();
            
            //------------------------------Grupo Anjo Azul------------------------------------------
            defaultCaccc.Add(new Caccc()
            {
                Celular = "(11) 96858-2990",
                Nome = "Cândida Bermejo Camargo",
                Apelido = "Centro CBC",
                Telefone = "(11)3224-2990",
                Email = "centrocbc@centrocbc.com.br",
                EmailPagSeguro = "financeiro@grupoanjoazul.com.br",
                Autorizado = false,
                Responsavel = "",
                UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_caccc.png",
                Cnpj = "03.333.146/0001-47",
                TipoDoacao = TipoDoacao.PagSeguro,
                Endereco = new Endereco()
                {
                    Logradouro = "Miguel Gonçalves Correia",
                    Numero = "157",
                    Bairro = "Vila Pirajussara, Campo Limpo",
                    Cidade = "São Paulo",
                    Cep = "05786-160",
                    Estado = "SP",
                    Latitude = -23.6350549,
                    Longitude = -46.7713119
                },
                Boletins = new List<Boletim>()
                {
                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Campanha,
                                   Nome ="Prestes a ser fechada",
                                   UrlImagem="http://doacaomais.adilsonlustoza.com.br/Arquivos/DoacaoMais/Imagens/noticia_caccc_eliana.webp",
                                   Descricao =@"<p>A CASA do Centro de Apoio C&acirc;ndida Bermejo Camargo est&aacute; prestes a ser leiloada e fechada.</p>

                                                            <p>A possibilidade de perder esse trabalhoque acabou de completar 18 anos em 2017 &eacute; eminente e N&Atilde;O podemos deixar nossas dezenas crian&ccedil;as e seus acompanhantes desamparados dos nossos cuidados e sem moradia.</p>

                                                            <p>Nesses 18 anos, s&oacute; n&oacute;s sabemos o qu&atilde;o dif&iacute;cil foi a nossa trajet&oacute;ria para caminhar de acordo com todas as leis que envolvem o terceiro setor e as crian&ccedil;as.</p>

                                                            <p> Sempre zelamos pela transpar&ecirc;ncia e regularidade do nosso trabalho, mas infelizmente, nem todas as pessoas conseguem enxergar a beleza e sinceridade no nosso trabalho e conseguiram nos prejudicar.</p>

                                                            <p>POR FAVOR,entre nessa corrente do bem, nos ajude arrecadar o valor para recuperar a Casa de Apoio e manter o trabalho em prol das mais de 700 crian&ccedil;as carentes com c&acirc;ncer que j&aacute; foram atendidas ao longo desses 18 anos de CBC.</p>

                                <p>E ajude as dezenas das crian&ccedil;as carentes com c&acirc;nce seus acompanhantes a continuarem o seu tratamento conosco.</p>"},


                },
                Bazares = new List<Bazar>()

                {
                    new Bazar(){Nome="BAZAR BENEFICENTE",Informacao="Funcionamento todos os dias das 10 as 17hs",   Endereco = new Endereco(){Logradouro="Rua Miguel Gonçalves Correa",Numero="308", Bairro = "Vila Pirajussara, Campo Limpo",Cep="00000-000",Cidade="São Paulo",Estado="SP",Latitude=-23.6357489,Longitude=-46.7724721 },UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/bazar01_img01_caccc.jpg" },
                    new Bazar(){Nome="ASSOCIAÇÃO INTERNACIONAL DE INTERESSE A HUMANIDADE",Informacao="Realizamos este bazar uma vez por mês", Endereco = new Endereco(){Logradouro="Av. Rudge Ramos",Numero="545", Bairro = "Jd. Irene ",Cep="00000-000",Cidade="São Paulo",Estado="SP",Latitude=-23.6629043,Longitude=-46.794212  },UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/bazar02_img01_caccc.jpg"  },
                    new Bazar(){Nome="BAZAR BENEFICENTE",Informacao="Funcionamento todos os dias das 9 as 17hs",Endereco = new Endereco(){Logradouro="Rua Nicolau Ávila",Numero="45", Bairro = "Vila Pirajussara, Campo Limpo",Cep="00000-000",Cidade="São Paulo",Estado="SP",Latitude=-23.6357489,Longitude=-46.7724721  } ,UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/bazar03_img01_caccc.jpg" }

                },
                Conteudos = new List<Conteudo>() {

                      new Conteudo(){
                                  Titulo ="HISTÓRIA",
                                  Subtitulo ="",
                                  Coluna =@"<p>O CENTRO DE APOIO &Agrave; CRIAN&Ccedil;A CARENTE COM C&Acirc;NCER - C&Acirc;NDIDA BERMEJO CAMARGO - CACCC-CBC, nasceu da iniciativa da Sra. Jovaneide e Eliana, com o intuito de abrigar, apoiar e cuidar de fam&iacute;lias, cujas crian&ccedil;as precisam de tratamento oncol&oacute;gico.</p>

                                <p>O tratamento gratuito sempre demora meses e a casa cuida para que os pequenos sejam atendidos nos hospitais, providenciando hospedagem, transporte, alimenta&ccedil;&atilde;o e muito carinho &agrave;s crian&ccedil;as, bem como aos acompanhantes respons&aacute;veis, para que o atendimento regular e permanente seja garantido.</p>

                                <p> E tudo isto &eacute; provido com muito empenho de volunt&aacute;rios e pessoas que nos apoiam.</p>"},


                    new Conteudo(){
                                  Titulo ="OBJETIVO",
                                  Subtitulo ="",
                                  Coluna =@"<p>O Centro 'CBC' tem como objetivo proporcionar &agrave;s crian&ccedil;as e seus acompanhantes, que vem de outros estados, em busca de tratamento, uma exten&ccedil;&atilde;o de seus lares, com moradia, alimenta&ccedil;&atilde;o, transporte e o que se fizer necess&aacute;rio para o bem estar de todos..</p>" }



                },
                ContasBancarias = new List<ContaBancaria>() {
                    new ContaBancaria(){
                        NomeBanco="Itau",
                        Agencia="806",
                        Conta="48600-4",
                        Beneficiario="Centro de Apoio à Criança Carente com Câncer"

                    }


                },

                Noticias = new List<Noticia>() {

                    new Noticia(){
                                  Titulo ="Auxilio Doença",
                                  SubTitulo="",
                                  UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/auxilio_doenca.jpg",
                                  Conteudo=@"<p>Beneficia, mensalmente, os portadores de c&acirc;ncer inscritos no Regime Geral de Previd&ecirc;ncia Social.</p>
                                <p>Para isso &eacute; necess&aacute;rio que os enfermos comprovem, por meio de exames realizados pela per&iacute;cia m&eacute;dica do INSS, que est&atilde;o temporariamente incapazes para trabalhar por mais de 15 dias consecutivos.</p>
                                <p>Para solicitar o aux&iacute;lio &eacute; necess&aacute;rio que os pacientes compare&ccedil;am ao posto da Previd&ecirc;ncia Social mais pr&oacute;ximo para agendamento de per&iacute;cia m&eacute;dica, portando sua Carteira de Trabalho ou os documentos que comprovem a sua contribui&ccedil;&atilde;o ao INSS, mais a declara&ccedil;&atilde;o ou o exame m&eacute;dico que descreva seu estado cl&iacute;nico.</p>
                                <p>A partir do 16&deg; dia afastado do trabalho, o segurado empregado come&ccedil;a a receber o benef&iacute;cio.</p>
                                <p>Os segurados desempregados recebem a partir da data do in&iacute;cio da sua incapacidade ou de entrada do requerimento</p>",
                                 DataPublicacao = null
                      },

                    new Noticia(){
                                  Titulo ="Sua Empresa causa uma boa primeira impressão?",
                                  SubTitulo="",
                                  UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/business_people.jpg",
                                  Conteudo=@"<p>Em vez de manter uma pol&iacute;tica de doa&ccedil;&otilde;es ao acaso, seria melhor abra&ccedil;ar uma causa social e se tornar conhecido como o mantenedor dela. Se estes esfor&ccedil;os estiverem concentrados em um problema ou necessidade, a sua empresa vai transmitir uma primeira boa impress&atilde;o a todos.</p>
                                <p>As primeiras empresas a investir em projetos sociais ser&atilde;o as primeiras a abra&ccedil;ar as causas de maior impacto, as &ldquo;melhores causas&rdquo;. Os retardat&aacute;rios na filantropia estrat&eacute;gica ficar&atilde;o com as causas de menor impacto ou ter&atilde;o a necessidade de pesquisar constantemente para descobrir novas causas ou necessidades que ir&atilde;o aparecer com o tempo.</p>
                                <p>Causar uma primeira boa impress&atilde;o deveria ser a primeira preocupa&ccedil;&atilde;o no planejamento estrat&eacute;gico de uma empresa. Muitas campanhas publicit&aacute;rias s&atilde;o no fundo, tentativas criadas para induzir o consumidor em potencial a realizar a sua primeira compra.</p>
                                <p>Ao oferecerem descontos, garantia de satisfa&ccedil;&atilde;o ou o dinheiro de volta, estar&atilde;o induzindo a primeira compra, sem ter causado uma primeira boa impress&atilde;o no cliente. Os profissionais de marketing est&atilde;o enclausurados na id&eacute;ia de que a primeira impress&atilde;o tem que estar relacionada ao produto. A pergunta provocativa que coloco &eacute; se realmente este &eacute; o &uacute;nico caminho, e se &eacute; a maneira mais barata de chegar a este objetivo.</p>
                                <p>Um projeto social coloca a marca na sua empresa, n&atilde;o nos produtos, e define a sua companhia como uma organiza&ccedil;&atilde;o s&eacute;ria, um cidad&atilde;o corporativo, uma empresa com conte&uacute;do, com integridade. Nessa era, devido ao culto &agrave; individualidade, empresas ser&atilde;o vistas e julgadas pelos mesmos padr&otilde;es que costumamos julgar indiv&iacute;duos. N&atilde;o pelo que voc&ecirc; faz, mas pelo que voc&ecirc; &eacute;.</p>
                                <p>Assim, a grande quest&atilde;o que qualquer membro do conselho executivo deve fazer &eacute; &ldquo;A nossa empresa causou uma primeira boa impress&atilde;o em consumidores potenciais suficientes para garantir crescimento?&rdquo;. &ldquo;N&oacute;s causamos<br /> uma primeira boa impress&atilde;o em cada universit&aacute;rio, futuros acionistas e governantes oficiais?&rdquo;<br /> Stephen Kanitz</p>",
                                DataPublicacao = null
                      },

                    new Noticia(){
                                  Titulo ="O que é terceiro setor?",
                                  SubTitulo="",
                                  UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/cancer_kid.png",
                                  Conteudo=@"<p>O primeiro setor &eacute; o governo, que &eacute; respons&aacute;vel pelas quest&otilde;es sociais. O segundo setor &eacute; o privado, respons&aacute;vel pelas quest&otilde;es individuais. Com a fal&ecirc;ncia do Estado, o setor privado come&ccedil;ou a ajudar nas quest&otilde;es sociais, atrav&eacute;s das in&uacute;meras institui&ccedil;&otilde;es que comp&otilde;em o chamado terceiro setor.</p>
                                <p>Ou seja, o terceiro setor &eacute; constitu&iacute;do por organiza&ccedil;&otilde;es sem fins lucrativos e n&atilde;o governamentais, que tem como objetivo gerar servi&ccedil;os de car&aacute;ter p&uacute;blico.</p>
                                <p>Os principais personagens do terceiro setor s&atilde;o:</p>
                                <p>Funda&ccedil;&otilde;es</p>
                                <p>S&atilde;o as institui&ccedil;&otilde;es que financiam o terceiro setor, fazendo doa&ccedil;&otilde;es &agrave;s entidades beneficentes. No Brasil, temos tamb&eacute;m as funda&ccedil;&otilde;es mistas que doam para terceiros e ao mesmo tempo executam projetos pr&oacute;prios.</p>
                                <p>Nos Estados Unidos j&aacute; existem 40.000 funda&ccedil;&otilde;es, sendo que a 10&ordm; colocada tem 10 bilh&otilde;es de d&oacute;lares de patrim&ocirc;nio. Nossa maior funda&ccedil;&atilde;o tem 1 bilh&atilde;o.</p>",
                                DataPublicacao = null
                      },

                    new Noticia(){
                                  Titulo ="Faça agora uma doação com PagSeguro",
                                  SubTitulo="",
                                  UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/doacao.jpg",
                                  Conteudo=@"<p>Colabore com quanto desejar, mas n&atilde;o esque&ccedil;a de nos enviar seus dados, enviaremos seu recibo e fazemos quest&atilde;o de mostrar como vai ser aplicado sua oferta.</p>",
                                DataPublicacao = null
                      }


                },




            });
            //-----------------------------Grupo AACC - Associacao de Apoio--------------------------
            defaultCaccc.Add(new Caccc()
            {
                Celular = null,
                Nome = "AACC - Associação de Apoio a Criança com Cancer",
                Apelido = "Associação de Apoio a Criança com Cancer",
                Telefone = "(11) 5084-5434",
                Email = "contato@aacc.org.br",
                EmailPagSeguro = "doacoesonline@aacc.org.br",
                EmailPayPal = "doacoesonline@aacc.org.br",
                UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc.png",
                Cnpj = "54.963.061/0001-83",
                TipoDoacao = TipoDoacao.PagSeguro_PayPal,
                Autorizado = false,
                Responsavel = "",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua Borges Lagoa, 1603",
                    Numero = "30",
                    Bairro = "Vila Clementino",
                    Cidade = "São Paulo",
                    Cep = "05854-020",
                    Estado = "SP",
                    Latitude = -23.5964588,
                    Longitude = -46.6523728
                },
                Boletins = new List<Boletim>()
                {
                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Projeto,
                                   Nome ="Apoio Psicológico",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png",
                                   Descricao =@"<p>O apoio psicol&amp;oacute;gico oferecido pela AACC visa proporcionar a interven&amp;ccedil;&amp;atilde;o psicol&amp;oacute;gica para a crian&amp;ccedil;a com c&amp;acirc;ncer e seus familiares na Casa de Apoio da AACC, para oferecer um espa&amp;ccedil;o para que sejam acolhidos desde sua chegada e durante o per&amp;iacute;odo de perman&amp;ecirc;ncia na institui&amp;ccedil;&amp;atilde;o.</p>

                            <p>Com isso se pretende melhorar a qualidade de vida, minimizar a ang&amp;uacute;stia frente &amp;agrave;s poss&amp;iacute;veis mudan&amp;ccedil;as f&amp;iacute;sicas e psicol&amp;oacute;gicas, transmitir informa&amp;ccedil;&amp;otilde;es sobre a doen&amp;ccedil;a e seu tratamento, permitindo uma maior ades&amp;atilde;o e implica&amp;ccedil;&amp;atilde;o no tratamento.</p>

                             <p>Muitas vezes o c&amp;acirc;ncer est&amp;aacute; relacionado com dor e sofrimento, al&amp;eacute;m de ser reconhecido como uma doen&amp;ccedil;a potencialmente terminal. Por isso, ao receber o diagn&amp;oacute;stico de c&amp;acirc;ncer, h&amp;aacute; a necessidade de reorganiza&amp;ccedil;&amp;atilde;o de todo o sistema familiar de modo a adaptar &amp;agrave; condi&amp;ccedil;&amp;atilde;o de perda iminente, presta&amp;ccedil;&amp;atilde;o de cuidados e mudan&amp;ccedil;as impostas pela realidade do tratamento do c&amp;acirc;ncer.</p>

                            <p>Por vezes ocorre a mudan&amp;ccedil;a de cidade e consequente distanciamento da fam&amp;iacute;lia, amigos, havendo a interrup&amp;ccedil;&amp;atilde;o de planos futuros, mudan&amp;ccedil;as f&amp;iacute;sicas e ps&amp;iacute;quicas, mudan&amp;ccedil;a no papel social e do estilo de vida. O trabalho desenvolvido pela a AACC considera todos estes aspectos.</p>"




                    },

                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Projeto,
                                   Nome ="Alojamento",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png",
                                   Descricao =@"<p align='justify'>O alojamento é a unidade da AACC que oferece ao paciente com câncer e à sua família,  desde o início do tratamento, o suporte bio-psicossocial necessário, que envolve o comprometimento de uma equipe multiprofissional e a relação com  diferentes setores da sociedade envolvidos no apoio às famílias e à saúde de crianças e jovens. Por isso, a AACC organiza diversas atividades que favoreçam o bem-estar dos atendidos para que a qualidade de vida dos usuários seja uma ferramenta a mais no processo de cura, organizando atividades culturais, passeios estratégicos que coloquem as crianças em contato com pessoas que contribuem com as artes e os desportos, a fim de despertar o sentimento e a vontade de crescimento entre elas.</p>"},

                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Campanha,
                                   Nome ="AACC em Construindo o Futuro",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/proj_constr_final.png",
                                   LinkWeb="@/Arquivos/Imagens/DoacaoMais/visite.jpg",
                                   Descricao =@"<p align='justify'>As forma&ccedil;&otilde;es ter&atilde;o dura&ccedil;&atilde;o de um ano e incluem &aacute;reas como planejamento estrat&eacute;gico, gest&atilde;o de projetos, capta&ccedil;&atilde;o de recursos, jur&iacute;dico financeiro, comunica&ccedil;&atilde;o e advocacy. Durante as forma&ccedil;&otilde;es, atrav&eacute;s de encontros presenciais e online, os participantes ter&atilde;o a oportunidade de refletir suas pr&aacute;ticas organizacionais e planejar cen&aacute;rios para suas atividades a curto, m&eacute;dio e longo prazo, de forma a criar melhores possibilidades de futuro para as comunidades em que atuam, com foco na expans&atilde;o de impacto e na melhoria da qualidade do servi&ccedil;o prestado. O projeto conta tamb&eacute;m com consultorias estrat&eacute;gicas para que cada Organiza&ccedil;&atilde;o beneficiada possa desenvolver sua pr&oacute;pria Teoria de Mudan&ccedil;a e um Plano de Monitoramento e Avalia&ccedil;&atilde;o de suas atividades e resultados&rdquo;, informa os idealizadores do projeto, Instituto Esp&iacute;rita de Educa&ccedil;&atilde;o. <br /> O projeto conta tamb&eacute;m com consultorias estrat&eacute;gicas para que cada Organiza&ccedil;&atilde;o beneficiada possa desenvolver sua pr&oacute;pria Teoria de Mudan&ccedil;a e um Plano de Monitoramento e Avalia&ccedil;&atilde;o de suas atividades e resultados. <br /> Ainda, com o intuito de assegurar o desenvolvimento significativo e alinhado de cada organiza&ccedil;&atilde;o de acordo as tem&aacute;ticas das capacita&ccedil;&otilde;es e consultorias, o Construindo o Futuro promover&aacute; 4 desafios no decorrer do projeto&rdquo;, completam.</p>.",

                                Notificacoes = new List<Notificacao>()
                                              {

                                                     new Notificacao(){
                                                         Ativa =true,
                                                         Descricao ="Menina de cinco anos luta contra câncer e precisa de leite especial",
                                                         Titulo ="Menina de cinco anos luta contra câncer e precisa de leite especial",
                                                         Conteudo ="Após filha caçula passar por cirurgia para combater o câncer e ficar paraplégica e sem se comunicar, os pais desempregados pedem ajuda para sobreviver na Capital. Eles trocaram o interior por Campo Grande para salvar a filha.",
                                              DataInicial=DateTime.Now.AddDays(-1),DataFinal=DateTime.Now.AddDays(2)},


                                                         new Notificacao(){
                                                         Ativa =true,
                                                         Descricao ="É um fato conhecido de todos que um leitor se distrairá?",
                                                         Titulo ="Porque nós o usamos",
                                                         Conteudo ="É um fato conhecido de todos que um leitor se distrairá com o conteúdo de texto legível de uma página quando estiver examinando sua diagramação",DataInicial=DateTime.Now.AddDays(4),DataFinal=DateTime.Now.AddDays(9)},

                                              },




                    }


                },
                Bazares = new List<Bazar>()
                {
                    new Bazar(){Nome="Bazar Beneficente Permanente",Informacao="Localizado na Sede da AACC", Endereco = new Endereco(){Logradouro="Rua Borges Lagoa",Numero="1603", Bairro = "Vila Clementino",Cep="00000-000",Cidade="São Paulo",Estado="SP"
                    , Latitude = -23.5964588, Longitude = -46.6523728 },UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.jpg"

                    }

                },
                Conteudos = new List<Conteudo>() {

                      new Conteudo(){
                                  Titulo ="Nossa História",
                                  Subtitulo ="11/04/1985",
                                  Coluna =@"<p>A nossa história começa em 11 de abril de 1985 por iniciativa do casal José Marcus Rotta e Wanir Leão Cavalcanti Rotta após experiência numa casa de apoio em Seattle, EUA, no período de 1983 a abril de 1984, em decorrência do tratamento do filho Thiago, vítima de leucemia.</p> "},

                      new Conteudo(){
                                  Titulo ="Inauguração Do Suporte Educacional",
                                  Subtitulo ="02/05/1995",
                                  Coluna =@"<p>Com o objetivo de facilitar a reinserção social da criança e do adolescente com câncer, desenvolvendo habilidades, recuperando sua defasagem escolar durante o tratamento e adotando uma postura que considere uma perspectiva de cura, a Associação de Apoio à Criança com Câncer inaugura o Suporte Educacional em 1995, a escola da criança com câncer em São Paulo.</p>"},

                      new Conteudo(){
                                  Titulo ="Lançamento Da Revista Da AACC",
                                  Subtitulo ="02/12/1996",
                                  Coluna =@"O ano de 1992 marcou o lançamento da Revista da AACC - Órgão oficial da Associação de Apoio à Criança com Câncer." },

                      new Conteudo(){
                                  Titulo ="Casa Nova Da AACC Na Vila Mariana",
                                  Subtitulo ="02/09/1997",
                                  Coluna =@"<p>Casa Nova AACC inaugurada na Vila Mariana. A Entidade galga espaço para crescer , ainda mais, com a implantação de novos projetos, informatização do fluxo de informações, com o objetivo de que a AACC se torne cada vez mais conhecida em nossa sociedade.</p>" },

                      new Conteudo(){
                                  Titulo ="Nova Fase No Suporte Educacional Da AACC",
                                  Subtitulo ="20/11/1997",
                                  Coluna =@"<p>Começa uma nova etapa. A AACC triplica a capacidade de atendimento do Suporte Educacional.</p>
                                <p>Combinando bom gosto, conforto, simplicidade e harmonia, ingredientes estes que fazem da nova estrutura um recanto aconchegante para receber crianças e adolescentes do Brasil todo que procuram a Entidade em busca de auxílio.</p>" }


                },
                ContasBancarias = new List<ContaBancaria>() {
                    new ContaBancaria(){
                        NomeBanco="Bradesco",
                        Agencia="0450-2",
                        Conta="112.100-6",
                        Beneficiario="Razão Social: AACC – Associação de Apoio à Criança com Câncer"

                    },

                     new ContaBancaria(){
                        NomeBanco="Brasil",
                        Agencia="5934-X",
                        Conta=" 40.013-0",
                        Beneficiario="Razão Social: AACC – Associação de Apoio à Criança com Câncer"

                    }


                },

                Noticias = new List<Noticia>() {

                      new Noticia(){
                                  Titulo ="Livro “Câncer, Direito e Cidadania”",
                                  SubTitulo="",
                                  UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/cancer_livro.jpg",
                                  Conteudo=@"<p>O Livro “Câncer, Direito e Cidadania”, de autoria da Antonieta Barbosa, advogada e Pernambucana, é uma vasta pesquisa sobre os direitos dos pacientes com câncer.</p>

                                    <p>Após um diagnóstico de câncer de mama, ela decide resgatar os seus direitos, enfrentando e vencendo toda sorte de dificuldades, entraves jurídicos e burocráticos, além de uma cirurgia de mastectomia conservadora, quimioterapia, radioterapia e hormonioterapia.</p>

                                <p>Diante dessa experiências e das lições de vida que recebeu nessa caminhada, nasceu a ideia de escrever este livro, quetraz informações úteis e dicas importantes, em linguagem acessível, encorajando o paciente, já fragilizado pela doençae maltratado pela burocracia, a resgatar sua dignidade, a qual só o pleno exercício da cidadania pode proporcionar.</p>


                                <p>O livro busca esclarecer e informar os direitos do paciente no âmbito:Auxílio-doença</p>
                                    <ul>
                                        <li>Aposentadoria integral com adicional de 25% em alguns casos</li>
                                        <li>Atendimento domiciliar</li>
                                        <li>Isenção do Imposto de Renda</li> 
                                        <li>Redução da Contribuição Previdenciária</li> 
                                        <li>Isenção de IPI, ICMS, IOF e IPVA na compra de veículos, em caso
                                        de deficiência</li> 
                                        <li>Isenção de IPTU em alguns municípios</li> 
                                        <li>Saque do FGTS e do PIS/Pasep</li> 
                                        <li>Cirurgia de reconstrução mamária gratuita</li>
                                        <li>Quitação do financiamento imobiliário </li>
                                        <li>Resgate de prêmio de seguro e/ou previdência privada</li> 
                                        <li>Frequência escolar em regime especial</li>
                                        <li>Prioridade no andamento de processos e precatórios</li>
                                        <li>Medicamentos gratuitos</li>
                                        <li>Direitos frente aos Planos de Saúde e na relação médico-paciente</li>
                                    </ul>

                                    <p>Esses e outros direitos e benefícios constam no Livro “Câncer, Direito e Cidadania”, um verdadeiro “garimpo jurídico”, que traz ainda informações sobre os tipos e tratamentos do câncer, dicas de prevenção, estatísticas oficiais e um
                                    guia com sites e endereços de serviços gratuitos em todo o Brasil.</p>

                                    <p>Parceria com a AACC Indispensável não apenas ao paciente com câncer, mas também aos familiares, cuidadores, médicos, assistentes sociais, profissionais da área de saúde e advogados.</p>",
                                  DataPublicacao= null
                                   },

                      new Noticia(){
                                  Titulo ="AACC no Museu do Amanhã",
                                  SubTitulo="",
                                  UrlImagem=@"/Arquivos/Imagens/DoacaoMais/museu_amanha.jpg",
                                  Conteudo=@"<p>No aniversário seu aniversário de dois anos, o Museu do Amanhã, em parceria com a IBM Brasil, convida os seus visitantes a criar uma ponte entre a reflexão e a ação, a IRIS+.</p>
                                           <p>O assistente cognitivo construído com IBM Watson – plataforma de Inteligência Artificial para negócios – foi desenvolvido não somente para responder aos visitantes, mas também formular perguntas.</p>
                                           <p> O visitante será questionado sobre diversos temas que possam levá-lo a um engajamento social e, a partir de sua resposta, poderá experenciar o trabalho da AACC, que está na Exposição Principal.</p>"
                      }

                },

            });
            //----------------------------------Marta Kuboia-----------------------------------------
            defaultCaccc.Add(new Caccc()
            {
                Celular = "(11) 99900-7979",
                Nome = "CACC Marta Kuboiama",
                Apelido = "CACC Marta Kuboiama",
                Telefone = "(11) 5061-1456 ",
                Email = "cmk@cmk.org.br",
                UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marta_kuboiama.png",
                Cnpj = "07.882.523/0001-58",
                TipoDoacao = TipoDoacao.ContaBancaria,
                Autorizado = false,
                Responsavel = "",
                Endereco = new Endereco()
                {
                    Logradouro = "RUA JOÃO DE SANTA MARIA",
                    Numero = "320 ",
                    Bairro = "JARDIM DA SAÚDE",
                    Cidade = "São Paulo",
                    Cep = "04158-070",
                    Estado = "SP",
                    Latitude = -23.6205107,
                    Longitude = -46.6199603
                },
                Boletins = new List<Boletim>()
                {
                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Projeto,
                                   Nome ="Cobertura",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png",
                                   Descricao =@"Enquanto o paciente realiza seu tratamento no hospital ao qual foi encaminhado, o
                                                    CMK oferece hospedagem, que pode se estender por meses, aos pacientes que não tem aonde permanecer durante o período do tratamento.

                                                    A hospedagem consiste em oferecer um ambiente adequado necessário à condição de indivíduos imunodeficientes, isto é, que tenham pouca ou nenhuma imunidade e que na grande maioria das vêzes não irão encontrar essa situação em casa de parentes, visto que falamos de pacientes carentes.

 

                                                    Há um serviço de transporte para que essas crianças sejam levadas ao hospital para exames, tratamento ou avaliações médicas e, alimentação saudável com orientação de uma nutricionista para suprir as necessidades e dificuldades individuais de cada uma das crianças.

                                                    A casa abriga mãe, irmã ou tia do paciente para oferecer um ponto de referência afetivo, fazendo com que a criança se sinta mais segura no ambiente que lhe é desconhecido.Assim também um apoio psicológico para crianças e mães, para que encontrem um equilíbrio e tentem superar a dor de sua condição física e de sofrimento.

 

                                                    Há brinquedoteca, para que tenham lazer em sua permanência na casa e, programação de aulas de culinária, música, palestras de interesse geral e especifico das doenças neoplásicas. Além de terapias e trabalhos manuais com a intenção de aliviar a tensão, oferecendo e criando oportunidade de aprender uma atividade que possa ser útil como sustento no futuro.

                                                    Resumindo, o CMK foi idealizado para que o paciente faça seu tratamento no hospital mas tenha nosso total apoio para que esse seja um sucesso e o que depender de nós que também esses pequenos meninos e meninas jamais carreguem traumas psicológicos referentes a doença durante o período que o acompanharemos."},

                     new Boletim(){
                                   tipoCampanha =TipoBoletim.Projeto,
                                   Nome ="Apoio",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png",
                                   Descricao =@"O CMK oferece vários tipos e formas de apoio a todos que utilizarem nossos serviços, para que todos tenham maior segurança possível na permanência sob nossa administração durante os tratamentos.

                                            Estes apoio é feito por volutários altamente qualificados e atuantes no mercado, que se comprometeram a oferecer seus conhecimentos em cada área específica, em prol dos pacientes.

                                            Hoje o CMK oferece suporte nas seguintes áreas (clique para conhecer cada uma das atuações):

                                Acompanhantes
                                Nutrição
                                Psicológico
                                Médico
                                Jurídico"},

                     new Boletim(){
                                  tipoCampanha=TipoBoletim.Depoimento,
                                  Nome ="Agradecimentos",
                                  UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_marca_aacc.png",
                                  Descricao=@"O CMK agradece imensamente ao Supermercado Hirota-Natal solidário 2017
                                                e aos 4 clientes sorteados, por ter nos indicado doando 1mil reais cada para                 nossa instituição. Agradecemos de coração!!!!!"},



                },
                Bazares = null,

                Conteudos = new List<Conteudo>() {

                      new Conteudo(){
                                  Titulo ="Histórico",
                                  Subtitulo ="",
                                  Coluna =@"O CMK – Centro de Apoio à Criança com Câncer Marta Kuboiama é uma entidade sem fins lucrativos e foi fundado em 11 de janeiro de 2006 graças à iniciativa de Marta Kuboiama, portadora de câncer desde 1994 e, de Dirce Kuboyama, irmã de Marta, que atua na área da saúde pública há mais de vinte anos.

                                A idéia da realização de um projeto para crianças carentes portadoras de câncer nasceu após anos de convivência com a realidade da população carente portadora de câncer.

                                O projeto visa atender às crianças portadoras de câncer oriundas de todo território nacional e acolhê-las durante seu tratamento em São Paulo. Para isso, planejam oferecer uma casa equipada para atender a todas as necessidades dos pacientes e seus acompanhantes.

                                Desde então, o CMK promove o apoio à crianças em hospitais e suas famílias."}



                },
                ContasBancarias = new List<ContaBancaria>() {
                    new ContaBancaria(){
                        NomeBanco="Bradesco",
                        Agencia="108-2",
                        Conta="182180-6",
                        Beneficiario="CNPJ : 07.882.523/0001-58 - MJ: 08071.005685/2008-14 - CMDCA:1718/12"

                    }

                },

                Noticias = null

            });
            //----------------------CAMACC - Casa Modelo de Apoio à Criança com Câncer---------------
            defaultCaccc.Add(new Caccc()
            {
                Celular = null,
                Nome = "CAMACC - Casa Modelo de Apoio à Criança com Câncer",
                Apelido = "CAMACC",
                Telefone = "(11) 3739-3859",
                Email = "casamodelo@ig.com.br",
                EmailPagSeguro = null,
                UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_camacc.png",
                Cnpj = "05.500.597/0001-57",
                TipoDoacao = TipoDoacao.ContaBancaria,
                Autorizado = false,
                Responsavel = "",
                Endereco = new Endereco()
                {
                    Logradouro = "R. Almirante Aristides Guilhem",
                    Numero = "199",
                    Bairro = "Jd Jussara V Sonia",
                    Cidade = "São Paulo",
                    Cep = "05526-000",
                    Estado = "SP",
                    Latitude = -23.6029461,
                    Longitude = -46.7473632
                },
                Boletins = new List<Boletim>()
                {
                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Campanha,
                                   Nome ="Doações",
                                   LinkWeb=null,
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc-2.png",
                                   Descricao =@"Aceitamos  roupas, calçados, brinquedos, alimentos, fraldas, material de                      higiene pessoal e limpeza, etc."
                                  }
                },


                Bazares = null,

                Conteudos = new List<Conteudo>() {

                       new Conteudo(){
                                  Titulo ="Nossa missão",
                                  Subtitulo ="",
                                  Coluna =@"Promover a assistência psicossocial, médica e financeira às crianças com câncer,            de famílias carentes de todo Brasil."

                               },

                       new Conteudo(){
                                  Titulo ="Quem Somos",
                                  Subtitulo ="",
                                  Coluna =@"Fundada em setembro de 2002 por um grupo de voluntários, que conviveram com a  dificuldade de se manter em São Paulo os seus filhos e a eles mesmos durante o tratamento oncológico e que se estabeleceu a Casa Modelo de Apoio a Criança com Câncer.

                                Como e de conhecimento publico que o tratamento quando fornecido não contempla as questões de hospedagem da mãe e filho, alimentação, logística de transporte apoio social a criança e a mãe durante esse longo tempo, pois a maioria dos tratamentos demanda um período de permanência mínima de 12 meses de idas e vindas de hospital.

                                A grande maioria das crianças vem de outros estados, principalmente, do norte e nordeste do país, os quais não têm recursos suficientes como médicos e clinicas especializadas para diagnósticos complexos. Em muitos casos, o tratamento é longo com varias internações hospitalar, cirurgia, exames e transplantes que requerem tratamento especial.

                                Muitas vezes por falta de informação as famílias não têm conhecimento desse tipo de assistência que é gratuita e acabam desistindo do tratamento, pois não tem como se alimentar, como se locomover e nem onde ficar.."

                               }



                },
                ContasBancarias = new List<ContaBancaria>() {
                    new ContaBancaria(){
                        NomeBanco="Bradesco",
                        Agencia="2799-5",
                        Conta="9480-3",
                        Beneficiario="CNPJ : 05.500.597/0001-57"

                    }

                },

                Noticias = null,

            });
            //---------------------CAJEC - Casa José Eduardo Cavichio------------------------------
            defaultCaccc.Add(new Caccc()
            {
                Celular = null,
                Nome = "CAJEC - Casa José Eduardo Cavichio",
                Apelido = "CAJEC",
                Telefone = "(11) 4701-4194",
                Email = "apoio@cajec.org.br",
                EmailPagSeguro = null,
                UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cajec.png",
                Cnpj = "05.500.597/0001-57",
                TipoDoacao = TipoDoacao.ContaBancaria,
                Autorizado = false,
                Responsavel = "",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua Preciosa",
                    Numero = "86",
                    Bairro = "Parque Monte Alegre",
                    Cidade = "Taboão da Serra",
                    Cep = "06756-170",
                    Estado = "SP",
                    Latitude = -23.6010249,
                    Longitude = -46.7744426
                },
                Boletins = new List<Boletim>()
                {
                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Parceiro,
                                   Nome ="TEMOS O APOIO DA RISÜ",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/apoio_risu.jpg",
                                   Descricao =@"A CAJEC  Casa Eduardo José Cavichio apoia a Risü. 
                                               Risü: https://www.risu.com.br/",
                                   DataInicial= new DateTime(),
                                   DataFinal=new DateTime(),
                                  },
                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Depoimento,
                                   Nome ="GABRIELA",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc-2.png",
                                   Descricao =@"A história da Gabriela é impressionante, ela chegou na CAJEC ainda bebê, com problemas nos rins. Passou por remédios, muita gente não acreditava na sua recuperação, mas aos poucos ela foi vencendo obstáculos, muito duros até para um adulto, e foi sobrevivendo. Sua mãe biológica a abandonou na Instituição ainda pequena e foi a D.Luiza quem cuidou dela. Hoje, ela é uma adolescente. Seu pequeno porte porém , não condiz com a sua idade e volta e meia ela tem sua saúde testada. Ela se tornou a “mascote “da Instituição. Pura alegria! Recebe as crianças que chegam com a maior desenvoltura e carinho.",
                                   DataInicial= new DateTime(),
                                   DataFinal=new DateTime(),
                                  },


                },

                Bazares = null,

                Conteudos = new List<Conteudo>() {

                       new Conteudo(){
                                  Titulo ="HISTÓRIA",
                                  Subtitulo ="",
                                  Coluna =@"A CAJEC é fruto do sonho de um rapaz de 16 anos, que lutou contra o câncer, e          inspirou a voluntária Maria Luiza Candido Centelles, fundadora / presidente da CAJEC, a colocar   em prática o sonho dele. E em janeiro de 1996, a Casa José Eduardo Cavichio foi aberta com o      objetivo de assistir crianças e adolescentes com câncer oriundas de todo o Brasil, e hoje        América Latina.
                                   Hoje, ele é uma estrela que brilha intensamente e ilumina todos os que lutam contra o câncer    infanto-juvenil."

                               },

                       new Conteudo(){
                                  Titulo ="O QUE FAZEMOS?",
                                  Subtitulo ="",
                                  Coluna =@"A CAJEC – Casa José Eduardo Cavichio – apoio a criança com câncer, instituição filantrópica, sem fins lucrativos, que desde 1996 assiste crianças e adolescentes com câncer de todo o Brasil e América Latina para realizar tratamento em hospitais na cidade de São Paulo.A vivência do adoecer, o tratamento fora domicílio, gera no assistido angustia e ansiedade. Pensando nisso, o trabalho da CAJEC é proporcionar uma estadia que acolhe, orienta para que mesmo longe de casa, ele possa se sentir em um lar.Desta forma a CAJEC oferece apoio psicológico, fisioterapêutico, assistente social e preocupa-se também com a convivência saudável ajudando no bem estar e na qualidade de vida."

                               }



                },

                ContasBancarias = new List<ContaBancaria>() {
                    new ContaBancaria(){
                        NomeBanco="Itaú",
                        Agencia="0300",
                        Conta="06000-1",
                        Beneficiario="CNPJ: 01.378.697/0001-00"

                    },
                      new ContaBancaria(){
                        NomeBanco="Bradesco",
                        Agencia="3084-8",
                        Conta="112.510-9",
                        Beneficiario="CNPJ: 01.378.697/0001-00"

                    },

                },


                Noticias = new List<Noticia>() {

                    new Noticia(){
                        Titulo="O QUE É O MOVIMENTO TODOS JUNTOS CONTRA O CÂNCER (TJCC)",
                        SubTitulo="",
                        Conteudo=@"Cenário do Brasil

                                O Brasil vem sofrendo mudanças relevantes em seu perfil demográfico e epidemiológico, consequência, entre outros fatores, do processo de urbanização, da industrialização e dos avanços da ciência e da tecnologia. A essas novas caraterísticas da sociedade brasileira, unem-se a mudança nos hábitos e estilos de vida e a exposição a fatores de risco próprios do mundo contemporâneo. 

                                A mudança demográfica, com consequente envelhecimento da população, associada à transformação nas relações entre as pessoas e o ambiente, acarretaram alterações importantes no perfil de morbimortalidade, diminuindo a ocorrência das doenças infectocontagiosas e colocando as doenças crônico-degenerativas no centro de atenção. O câncer é atualmente a segunda principal causa de morte no país, e estimam-se que serão 600 mil diagnósticos de câncer até o final de 2016.

                                   Para o sistema de saúde se aperfeiçoar e atender a toda essa demanda, garantindo o acesso, cobertura e efetividade na área da Oncologia, é necessária, além da atuação do governo, a participação de diversos interlocutores, tais como usuários, médicos e outros trabalhadores da área da saúde, estabelecimentos de saúde, pesquisadores, órgãos de controle, mídia, entre outros.

                                Observando o esforço fragmentado e a existência de inúmeras entidades e instituições estruturadas para dar apoio, oferecer assistência e defender os direitos das pessoas com câncer, além das diversas demandas apontadas pelos pacientes, familiares, médicos e profissionais de saúde, a Abrale - Associação Brasileira de Linfoma e Leucemia, vislumbrou uma iniciativa inovadora com o objetivo de aproximar os interessados do segmento. Para tal, propôs uma agenda colaborativa visando influenciar as políticas de saúde na área de oncologia e acelerar a promoção da saúde, a prevenção, o acesso ao tratamento e cuidados paliativos às pessoas com câncer no Brasil.",

                        UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/todos_contra_cancer.png",

                        DataPublicacao=new DateTime(2016,4,26)

                    }


                },

            });
            //----------------------Casa Maria Helena Paulina---------------------------------------
            defaultCaccc.Add(new Caccc()
            {
                Celular = null,
                Nome = "Casa Maria Helena Paulina",
                Apelido = "Casa Maria Helena Paulina",
                Telefone = "(11) 3744-7492",
                Email = "contato@casamariahelenapaulina.org.br",
                EmailPagSeguro = null,
                UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cmph.webp",
                Cnpj = "05.500.597/0001-57",
                TipoDoacao = TipoDoacao.ContaBancaria,
                Autorizado = false,
                Responsavel = "",
                Endereco = new Endereco()
                {
                    Logradouro = "R. Judith Passald Esteves",
                    Numero = "137",
                    Bairro = "Jd. Colombo",
                    Cidade = "São Paulo",
                    Cep = "06756-170",
                    Estado = "SP",
                    Latitude = -23.6010296,
                    Longitude = -46.7321669
                },
                Boletins = new List<Boletim>()
                {
                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Campanha,
                                   Nome ="Doe um Produto",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc-2.png",
                                   Descricao =@"Para mantermos nossas atividades, contamos com a doação de produtos para serem      usados em nossa casa ou vendidos em nosso bazar! 
                                    ​
                                 Simples e fácil: preencha o formulário abaixo e entraremos em contato por email para   confirmar a retirada do produto ou sua entrega diretamente em nossa sede (você pode escolher).  Nós buscamos produtos usados em boas condições, que permitam ser utilizados ou vendidos. Agradecemos imensamente a sua pequena doação! Ela é muito importante para nós!",
                                   DataInicial= new DateTime(),
                                   DataFinal=new DateTime(),
                                  },
                    new Boletim(){
                                   tipoCampanha =TipoBoletim.Depoimento,
                                   Nome ="Seja Voluntário",
                                   UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo-aacc-2.png",
                                   Descricao =@"De acordo com o Centro de Voluntariado de São Paulo  Ser voluntário é doar seu tempo, trabalho e talento  para causas de interesse social e comunitário e com isso melhorar a qualidade de vida da comunidade.
                                        Em nossa casa existem diversas formas e oportunidades de participação, você pode ajudar no entretenimento das crianças, organizando passeios ou nos ajudando com trabalho dentro da sua especialidade!",
                                   DataInicial= new DateTime(),
                                   DataFinal=new DateTime(),
                                  },


                },

                Bazares = new List<Bazar>(){
                      new Bazar() {
                            Nome = "Casa Maria Helena Paulina - Bazar no Taboão da Serra - ",
                            Informacao = @"Funcionamento: De segunda a sexta : das 9hrs - 18hrs Sábados: das 9hrs - 15hrs", Endereco = new Endereco() {
                                Logradouro = "R. Fideralina Gomes  de Almeida",
                                Numero = "324",
                                Bairro = "Jd. Record",
                                Cep = "06784-380",
                                Cidade = "Taboão da Serra",
                                Estado = "SP",
                                Latitude = -23.6355219,
                                Longitude = -46.7974825 },
                          UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/bazar_cmhp.png" }
                },

                Conteudos = new List<Conteudo>() {

                       new Conteudo(){
                                  Titulo ="Sobre nós",
                                  Subtitulo ="",
                                  Coluna =@"A Casa Maria Helena Paulina é uma organização não governamental paulista fundada em 1992 que acolhe jovens com câncer - ou outras enfermidades - e seus acompanhantes oriundos de diversos estados brasileiros que se encaminham para São Paulo em busca de infraestrutura de tratamento adequado às suas necessidades. Essas famílias quando chegam, encontram uma realidade tão difícil quanto a própria doença: falta de dinheiro, falta de informação e falta de condições para se manter na cidade durante o tratamento, que pode durar meses.​

                                 O diagnóstico e o tratamento fora de domicílio, interferem no equilíbrio e no bem estar do paciente. Pensando nisso, o trabalho da Casa é voltado a acolher as pessoas, tornando a estadia dos assistidos a melhor possível, como se estivessem em seu próprio lar.​

                                 Desta forma A Casa Maria Helena Paulina oferece moradia, alimentos, assistência psicológica, produtos de higiene e as mais variadas atividades, pois preocupa-se também com a convivência saudável ajudando no bem estar e na qualidade de vida"

                               },

                       new Conteudo(){
                                  Titulo ="Conheça a nossa História",
                                  Subtitulo ="",
                                  Coluna =@"Em 1992, a Casa Maria Helena Paulina abre suas portas. O sonho dessa enfermeira, também vítima de câncer, torna-se realidade. ​

                                A Sra. Maria Helena Paulina foi enfermeira do Hospital das Clínicas de São Paulo e ao se aposentar, descobriu-se portadora de câncer de mama. Durante seu tratamento, deparou-se com uma

                                problemática muito comum: a de famílias que vinham a São Paulo para tratamento médico e, por serem carentes, não tinham recursos para se hospedarem na cidade.                                ​

                                Na época existiam apenas duas casas de apoio na capital, que não supriam a necessidade e diversas pessoas passavam a noite na rua e debaixo de viadutos.  Sabendo como é o funcionamento de uma

                                casa de apoio e com informações suficientes, ela e suas duas primas, Marina e Regina, resolveram criar uma nova instituição, para que estas pessoas não permanecessem em condições tão subumanas durante um tratamento que além de ser demorado, exige diversos cuidados.

                                Inicialmente a casa funcionava com o trabalho da duas primas e outras pessoas que também tinham perdido um ente querido e eram solidárias à causa.                                ​

                                Em 1998, a Casa passou a ser acompanhada periodicamente pela Vara da Infância e da Juventude do Fórum Regional de Pinheiros, processo nº 900196/6 e possui registro no Conselho Municipal dos Direitos da Criança e do Adolescente sob no. 824/CMDCA/1999.                                ​

                                Hoje, a casa acolhe em média 20 pacientes e seus acompanhantes, totalizando 40 pessoas por vez, em esquema de rodízio."

                               }



                },

                ContasBancarias = new List<ContaBancaria>() {
                    new ContaBancaria(){
                        NomeBanco="Itaú",
                        Agencia="0062",
                        Conta="35.926-0",
                        Beneficiario="CNPJ: 69.107.142/0001-59"

                    },
                      new ContaBancaria(){
                        NomeBanco="Bradesco",
                        Agencia="0516",
                        Conta="70.758-9",
                        Beneficiario="CNPJ: 69.107.142/0001-59"

                    },

                       new ContaBancaria(){
                        NomeBanco="Brasil",
                        Agencia="3050-3",
                        Conta="2004-4",
                        Beneficiario="CNPJ: 69.107.142/0001-59"

                    }

                },


                Noticias = new List<Noticia>() {

                    new Noticia(){
                        Titulo="Câncer: Saiba Mais",
                        SubTitulo="",
                        Conteudo=@"Câncer (neoplasia, ou tumor maligno) é uma classe de doenças caracterizadas pelo                 crescimento descontrolado de células aberrantes.

                                Ele pode matar devido à invasão destrutiva de órgãos normais por estas células, por extensão direta ou por disseminação à distância, que pode ser através do sangue, linfa ou superfície serosa.

                                O comportamento anormal das células cancerosas é geralmente espelhado por mutações genéticas, expressões de características ontológicas, ou secreção anormal de hormônios ou enzimas. 

                                Todos os cânceres têm o potencial de invasão ou de metastatização, mas cada tipo específico tem características clínicas e biológicas, que devem ser estudadas para um adequado diagnóstico, tratamento e acompanhamento. 

​

                                   Para o sistema de saúde se aperfeiçoar e atender a toda essa demanda, garantindo o acesso, cobertura e efetividade na área da Oncologia, é necessária, além da atuação do governo, a participação de diversos interlocutores, tais como usuários, médicos e outros trabalhadores da área da saúde, estabelecimentos de saúde, pesquisadores, órgãos de controle, mídia, entre outros.

                                Observando o esforço fragmentado e a existência de inúmeras entidades e instituições estruturadas para dar apoio, oferecer assistência e defender os direitos das pessoas com câncer, além das diversas demandas apontadas pelos pacientes, familiares, médicos e profissionais de saúde, a Abrale - Associação Brasileira de Linfoma e Leucemia, vislumbrou uma iniciativa inovadora com o objetivo de aproximar os interessados do segmento. Para tal, propôs uma agenda colaborativa visando influenciar as políticas de saúde na área de oncologia e acelerar a promoção da saúde, a prevenção, o acesso ao tratamento e cuidados paliativos às pessoas com câncer no Brasil.",

                        UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/",

                        DataPublicacao=new DateTime(2016,4,26)

                    },

                      new Noticia(){
                        Titulo="Câncer: Causas e Tratamento",
                        SubTitulo="",
                        Conteudo=@"As causas que levam ao aparecimento de câncer nos jovens são diferentes das nos adultos.         Estão muito mais ligadas a fatores genéticos do que a exposição no ambiente a agentes carcinogênicos. 

                            Em aproximadamente 10 a 15% dos casos são reconhecidos outros casos na família, ou a criança possui alguma doença genética que confere maior propensão a determinados tipos de câncer, por exemplo, na Síndrome de Down, onde os portadores têm maior chance de desenvolver leucemia.

                            Outros fatores que estão associados ao aparecimento de câncer nesta idade seria: exposição à radiação ionizante, vírus (Epstein-Barr), exposição intrauterina a hormônio (diethylstilbestrol). Diferente dos adultos, não existe nenhum exame específico associado à idade que pode ser feito de rotina para se detectar precocemente o câncer na criança, na população geral. 

                            ​
                            O mais importante é que toda criança seja seguida periodicamente por um pediatra, como recomenda a OMS, e que os responsáveis levem a este pediatra se suspeitarem de qualquer sinal que a criança apresente. Este profissional deve ser capaz de examinar cuidadosamente e suspeitar de câncer caso seja pertinente e então encaminhar ao centro especializado que convém, mesmo sem a certeza do diagnóstico.

                                                          Tipos:

                              - Leucemia linfoblástica aguda 
                              - Leucemia mielocítica aguda 
                              - Cerebrais:Gliomas, astrocitomas cerebelar e
                                cerebral, meduloblastoma 
                              - Sarcoma de Ewing ou tumores da família Ewing 
                              - Tumor de células germinativas 
                              - Linfoma de Hodgkin 
                              - Linfoma Não-Hodgkin 
                              - Neuroblastoma 
                              - Câncer hepático 
                              - Osteossarcoma/Histiocitoma fibroso maligno
                                 do osso
                              - Retinoblastoma 
                              - Rabdomiossarcoma   
                              - Tumor de Wilms 
                              - Sarcoma de tecidos moles

                               Tratamento:                           ​

                              No câncer infantil, assim como nos adultos, o tratamento está baseado no uso de quimioterapia associada à cirurgia e radioterapia. O uso dessas armas vai depender do tipo e a extensão da doença ao diagnóstico. 
                            Porém, existe uma diferença crucial do tratamento de jovens em relação aos adultos: não podemos nos esquecer que estamos tratando pessoas em fase de crescimento e desenvolvimento. 
                            A radioterapia e mesmo o uso de várias drogas tóxicas ao organismo podem levar, a longo prazo, a conseqüências desastrosas para o futuro da criança como baixa altura ou até mesmo um segundo câncer. Isto torna ainda mais desafiador a luta contra o câncer e estimula a procura de novos métodos de tratamento mais eficientes e menos agressivos.

                            Dicas de Prevenção:

                              - Alimentação balanceada;
                              - Auto Exame: boca, mama, testículos, pele
                              - Uso de protetor Solar
                              - Higiene Íntima 
                              - Exames médicos periódicos

                            • Direitos do Paciente:

                              - Requerer aposentadoria
                              - Saque de FGTS
                              - Isenção de Imposto de Renda
                              - Insenção de ICMS e IPI para aquisição de veículos especiais
                              - Transporte público gratuito para pessoas de baixa renda
                              - Cirurgia plástica reparadora (mamas)

",

                        UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/todos_contra_cancer.png",

                        DataPublicacao=new DateTime(2016,4,26)

                    }
                },

            });
            //----------------------CAVD -CASA DE APOIO VIDA DIVINA---------------------------------
            defaultCaccc.Add(new Caccc()
            {
                Celular = null,
                Nome = "CAVD -CASA DE APOIO VIDA DIVINA",
                Apelido = "CAVD - CASA DE APOIO VIDA DIVINA",
                Telefone = "(11) 2545-2150",
                Email = "cavd@cavd.org.br",
                EmailPagSeguro = null,
                UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png",
                Cnpj = "000.0000.0000/000",
                TipoDoacao = TipoDoacao.ContaBancaria,
                Autorizado = false,
                Responsavel = "",
                Endereco = new Endereco()
                {
                    Logradouro = "Rua Martinho de Sousa",
                    Numero = "207",
                    Bairro = "Ermelino Matarazzo, Vila Paranaguá",
                    Cidade = "São Paulo",
                    Cep = "03807-290",
                    Estado = "SP",
                    Latitude = -23.5030268,
                    Longitude = -46.4750445
                },
                Boletins = new List<Boletim>()
                {
                     new Boletim(){
                                   tipoCampanha =TipoBoletim.Campanha,
                                   Nome ="TERRENO DA SEDE PRÓPRIA / CONTRIBUA",
                                   UrlImagem=@"http://www.cavd.org.br/wp-content/uploads/2015/02/site.png",
                                   Descricao =@"A Casa de Apoio Vida Divina já realiza o trabalho de acolhimento de crianças e adolescentes de outros estados há mais de 10 anos e desde então sempre foi em uma sede alugada. Muitas famílias já passaram por aqui e são gratas pelo espaço que tiveram enquanto necessário, também somos gratos pela história que fizemos juntos nessa casa, porém, acreditamos que podemos oferecer mais qualidade e segurança para as nossas crianças.
                                Por este motivo tiramos do papel um sonho que foi muito pensando pela fundadora da casa, Marli Francisca, a construção da sede própria da Casa de Apoio Vida Divina. O objetivo é poder ter espaço para receber mais famílias que precisam vir para São Paulo para cuidarem de suas crianças, além disso oferecer algumas atividades que hoje não é possível na sede atual como aulas em braile, fisioterapia com acompanhamento, atividades pedagógicas e lúdicas, tanto para as crianças quanto para os pais. Hoje já quitamos o valor do terreno onde está sendo construído a sede própria, mais para continuarmos essa história dependemos da sua ajuda, faça uma contribuição, toda ajuda é importante para nós, quem estende a mão para o próximo, abre o coração para o caminho do bem, juntos somos mais fortes.",
                                   DataInicial= new DateTime(),
                                   DataFinal=new DateTime(),
                                  },

                     new Boletim(){
                                   tipoCampanha =TipoBoletim.Campanha,
                                   Nome ="A HISTÓRIA CONTINUA",
                                   UrlImagem=@"http://www.cavd.org.br/wp-content/uploads/2015/02/site.png",
                                   Descricao =@"Em Set/2014, através das doações mensais - essenciais à CAVD -, conseguimos comprar o terreno onde será levantada a sede própria da Casa de Apoio Vida Divina.
Junto de toda a assistência prestada pela instituição, existem os gastos com produtos e a manutenção. Entretanto, no caso da CAVD, a situação é outra. A entidade ainda não possui uma sede própria, e por isso busca recursos para a construção de seu prédio, que já está em andamento. A todo momento buscamos a captação de recursos financeiros para a construção de nosso local próprio. A princípio arrecadamos fundos para a manutenção do prédio em que estamos instalados (que atualmente é alugado) e o que sobra é investido na obra da nossa sede oficial, que começou em julho de 2015.
Para colher os recursos, a CAVD reúne diversos tipos de eventos. Além disso, rifas esporádicas, boletos de doadores sócio mensalistas e os bazares da instituição complementam a renda da instituição. A Casa de Apoio Vida Divina também tem o Projeto dos Assistidos, onde 15 famílias são cadastradas. Elas geralmente necessitam de algum apoio, desde medicamentos, alimentação ou roupas. O benefício a elas é entregue mensalmente.

                                          ",
                                   DataInicial= new DateTime(),
                                   DataFinal=new DateTime(),
                                  },

                     new Boletim(){
                                   tipoCampanha =TipoBoletim.Projeto,
                                   Nome ="SEJA VOLUNTÁRIO",
                                   UrlImagem=@"http://www.cavd.org.br/wp-content/uploads/2015/02/site.png",
                                   Descricao =@"requentemente precisamos de ajuda em atividades, eventos e manutenções na Casa.                 Se quiser ser um voluntário, o processo é simples e de grande valia pra nós.

                                    Hoje você pode ser voluntário na casa de duas formas, se cadastrando aqui no site, preenchendo as informações corretas e quando a instituição realizar ações externas como festas, jantares, bingos ou ações entraremos em contato para verificar a disponibilidade de horário. Você também pode fazer um trabalho voluntário com as crianças da instituição, para isso entre em contato pelo telefone para mais informações.

                                    Somos gratos a todas as equipes que já nos ajudaram diversas vezes, já são mais de 10 anos de trabalho e muitos grupos já tiveram o prazer de fazer um dia mais feliz para as nossas crianças. Se cadastre, em breve entraremos em contato com você!


                                          ",
                                   DataInicial= new DateTime(),
                                   DataFinal=new DateTime(),
                                  }

                },

                Bazares = new List<Bazar>(){
                      new Bazar() {
                            Nome = "BAZAR FIXO CAVD (1)",
                            Informacao = @"Funcionamento: De segunda a sexta : das 9hrs - 18hrs Sábados: das 9hrs - 16hrs", Endereco = new Endereco() {
                                Logradouro = "Rua Martinho de Sousa",
                                Numero = "207",
                                Bairro = "Ermelino Matarazzo",
                                Cep = "00000-000",
                                Cidade = "São Paulo",
                                Estado = "SP",
                                Latitude = -23.5030268,
                                Longitude = -46.4750445
                            },
                          UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png" },

                      new Bazar() {
                            Nome = "BAZAR FIXO CAVD (2)",
                            Informacao = @"Funcionamento: De segunda a sexta : das 9hrs - 18hrs Sábados: das 9hrs - 16hrs", Endereco = new Endereco() {
                                Logradouro = "Avenida Paranaguá",
                                Numero = "378",
                                Bairro = "Ermelino Matarazzo",
                                Cep = "00000-000",
                                Cidade = "São Paulo",
                                Estado = "SP",
                                Latitude = -23.5026042,
                                Longitude = -46.4760628
                            },
                          UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png" },

                      new Bazar() {
                            Nome = "BAZAR FIXO CAVD (3)",
                            Informacao = @"Funcionamento: De segunda a sexta : das 9hrs - 18hrs Sábados: das 9hrs - 16hrs", Endereco = new Endereco() {
                                Logradouro = "Rua Maraial ",
                                Numero = "358",
                                Bairro = "Jardim Nordeste",
                                Cep = "00000-000",
                                Cidade = "São Paulo",
                                Estado = "SP",
                                Latitude = -23.5026042,
                                Longitude = -46.4760628
                            },
                          UrlImagem = @"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png" },


                },

                Conteudos = new List<Conteudo>() {

                       new Conteudo(){
                                  Titulo ="Sobre nós",
                                  Subtitulo ="",
                                  Coluna =@"A casa foi fundada em 2002 por Marli Francisca, atualmente presidente da                instituição. Infelizmente, ela perdeu sua mãe para o câncer, e a partir disso resolveu se       dedicar ao auxílio às mães e crianças que conheceu durante o tratamento de sua mãe nos          hospitais.

                                 A Casa de Apoio Vida Divina acolhe crianças e adolescentes com câncer de outros estados, todos acompanhados por seus responsáveis e moram aqui provisoriamente durante o tratamento de câncer na capital de São Paulo. Hoje a nossa missão é proporcionar a eles um tratamento digno com amor, esperança e oportunidade para vencer a luta contra o câncer. O apoio à criança com câncer é essencial em diversas esferas. Os pequenos doentes precisam de auxílio e tratamento adequado, mas as famílias também devem passar pela assistência. O local tem como casa o distrito de Ermelino Matarazzo. Além disso, é não-governamental e não possui fins lucrativos. Com mais de 10 anos de história a casa já recebeu maios de 500 famílias oriundas de diversas regiões do país."

                               },

                       new Conteudo(){
                                  Titulo ="Missão",
                                  Subtitulo ="",
                                  Coluna =@"Atender com qualidade as crianças e adolescentes com câncer e seus acompanhantes durante o tratamento na capital de São Paulo com o intuito de alcançar a cura com qualidade de vida. Oferecer hospedagem, alimentação, transporte, medicamento, atendimento social, pedagógico, atividades lúdicas e recreativas através de voluntários durante o período do tratamento."

                               },


                         new Conteudo(){
                                  Titulo ="Visão",
                                  Subtitulo ="",
                                  Coluna =@"Ser considerada como uma instituição de referência no modelo de apoio as crianças e adolescentes portadoras do câncer de todos os estados do Brasil."

                               },


                           new Conteudo(){
                                  Titulo ="Valores",
                                  Subtitulo ="",
                                  Coluna =@"Atuar no atendimento com comprometimento, solidariedade e amor a todos que buscam o nosso apoio."

                               }



                },

                ContasBancarias = new List<ContaBancaria>() {
                    new ContaBancaria(){
                        NomeBanco="Itaú",
                        Agencia="0682",
                        Conta="06237-7",
                        Beneficiario="Casa de Apoio Vida Divina"

                    },

                       new ContaBancaria(){
                        NomeBanco="Caixa Econômica Federal",
                        Agencia="1618",
                        Conta="817-3",
                        Beneficiario="Casa de Apoio Vida Divina"

                    }

                },



                Noticias = new List<Noticia>() {

                    new Noticia()
                    {
                        Titulo="ALICERCE CONTRA O CÂNCER",
                        SubTitulo="",
                        Conteudo=@"Na edição de Julho saiu no Jornal Cidadania do Grupo de Cidadania Empresarial uma matéria falando sobre o nosso trabalho, sobre os objetivos e desafios de 2016 e dos próximos anos, a matéria completa você encontra no site abaixo.

                        www.cidadania.fcl.com.br/alicerce-contra-o-cancer

                        Agradecemos a responsabilidade social da Fundação Cásper Libero e todas as empresas do Grupo de Cidadania Empresarial pela oportunidade e por virem conhecer um pouco mais da nossa história e luta, juntos somos mais fortes.",

                        UrlImagem=@"http://doacaomais.adilsonlustoza.com.br/Arquivos/Imagens/DoacaoMais/logo_cavd.png",

                        DataPublicacao=new DateTime(2016,8,4)

                    }



                },

            });

            foreach (Caccc caccc in defaultCaccc)
                context.Caccc.Add(caccc);

         
        }

    }
}
