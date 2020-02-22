using AppPrivy.InfraStructure;

namespace AppPrivy.Data.Interface
{
    public interface IContextManager
    {
        AppPrivyContext SiteContext();
        AppPrivyContext DoacaoMaisContext();
    }
}
