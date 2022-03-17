using MagicOnion;

namespace MagicOnionTest.Interface
{
    public interface ICService : IService<ICService>
    {
        UnaryResult<string> Hello(string message);
    }
}
