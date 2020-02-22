namespace AppPrivy.CrossCutting.Agregation
{
    public class ConstantQuery
    {
        public static string QueryUpdated = @"SELECT Tabela,Atualizacao FROM
                                                            (
                                                              SELECT  'Bazar' as Tabela, MAX(DataAtualizacao) AS Atualizacao
                                                              FROM DoacaoMais.Bazar
                                                              GROUP BY Tabela,DataAtualizacao
                                                            UNION 
                                                              SELECT  'Caccc' as Tabela,  MAX(DataAtualizacao) AS Atualizacao
                                                              FROM DoacaoMais.Caccc
                                                              GROUP BY Tabela,DataAtualizacao
                                                              UNION 
                                                            SELECT  'Noticia' as Tabela,  MAX(DataAtualizacao) AS Atualizacao
                                                              FROM DoacaoMais.Noticia
                                                            GROUP BY Tabela,DataAtualizacao
                                                            ) AS Externa
                                                        order by Atualizacao desc ,Tabela desc
                                                        limit 1;";

    }
}
