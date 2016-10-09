using System;
using Common;
using Ninject.Activation;
using Ninject.Modules;

namespace MyNinjectModules
{
    public class CtorProviderAndMethodModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<ILoggingSink>().ToMethod(x => GetLogger());
            
            Bind<ILoggingSink>().ToProvider<OfflineLoggingCompoentProvider>();

            Bind<IDomComponent>().ToConstructor(x => new CtorAndMethodComponent());

        }

        private ILoggingSink GetLogger()
        {
            return new DistributedLoggingSync();
        }
    }

    public class OfflineLoggingCompoentProvider : Provider<OffLineLoggingComponent>
    {
        protected override OffLineLoggingComponent CreateInstance(Ninject.Activation.IContext context)
        {
            //Normally there would be some really complex logic
            //here controling how this gets created
            return new OffLineLoggingComponent();
        }
    }
}