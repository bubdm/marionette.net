using Prism.Mef;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Marionette
{
    public class MarionetteBootstrapper : MefBootstrapper
    {
        /// <summary>
        /// We need to override this because we're changing which class the GUI launches
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject CreateShell()
        {
            return this.Container.GetExportedValue<Shell>();
        }

        /// <summary>
        /// Override the GUI class that gets initialized when the application launches.
        /// </summary>
        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        /// <summary>
        /// Where we look for plugins.
        /// 
        /// Our main program also counts as a plugin so needs to be registered
        /// so we can participate in the MEF system.
        /// </summary>
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MarionetteBootstrapper).Assembly));
            //this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(ChatModule).Assembly));
            //this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(AuthenticationModule).Assembly));

            var catalog = new DirectoryCatalog("plugins");
            this.AggregateCatalog.Catalogs.Add(catalog);

        }

        /// <summary>
        /// We don't want the default catalog type, so override it.
        /// </summary>
        /// <returns>A ConfigurationModuleCatalog</returns>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return base.CreateModuleCatalog();
        }
    }
}
