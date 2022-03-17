using Grpc.Core;
using MagicOnion;
using MagicOnion.Server;
using MagicOnionTest;
using MagicOnionTest.Interface;

namespace MagicOnionTest.Services
{
    public class CService : ServiceBase<ICService>, ICService
    {
        private readonly ILogger<CService> _logger;
        public CService(ILogger<CService> logger)
        {
            _logger = logger;
        }

        public async UnaryResult<string> Hello(string message)
        {
            return await Task.FromResult($"Hello,{message}!");
        }
    }
}