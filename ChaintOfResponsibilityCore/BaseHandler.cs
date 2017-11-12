using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaintOfResponsibilityCore
{
    public abstract class ChainHandler : IChainHandler
    {
        protected IChainHandler handler;
        public void ConfigurHandler(IChainHandler handler)
        {
            this.handler = handler;
        }

        public abstract string DoResponsibility(bool passIt);
    }

    public interface IChainHandler
    {
        string DoResponsibility(bool passIt);
    }
}
