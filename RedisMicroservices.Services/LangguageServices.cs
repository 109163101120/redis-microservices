using System.Threading;
using RedisMicroservices.Core.Distributed;
using RedisMicroservices.Domain;
using RedisMicroservices.Domain.DataModel;

namespace RedisMicroservices.Services
{
    public   class LangguageServices : ILangguageServices
    {
        private IDistributedServices _distributedServices;
        public void RegisterDistributed(IDistributedServices distributedServices)
        {
            _distributedServices = distributedServices;
        }

        public void Create(LanguageData data)
        {
            Thread.Sleep(1000);
        }

        public void DoSomething(LanguageData data)
        {
            Thread.Sleep(1000);
        }
    }
}