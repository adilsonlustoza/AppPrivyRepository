using AppPrivy.InfraStructure.Contexto;

namespace AppPrivy.InfraStructure.Interface
{
    public interface IContextManager
    {
        SiteContext SiteContext();
        DoacaoMaisContext DoacaoMaisContext();
    }
}
