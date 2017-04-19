using Ninject.Modules;
using Ninject.Web.Common;
using TestProject.Data.DataContext;

namespace TestProject.Web.NinjectModules
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            Bind<TestProjectContext>().ToSelf().InRequestScope();
            Bind<IDataContext>().To<TestProjectContext>().InRequestScope();
        }
    }
}