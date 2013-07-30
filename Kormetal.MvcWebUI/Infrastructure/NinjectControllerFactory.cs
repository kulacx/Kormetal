using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kormetal.Bll.Concrete;
using Kormetal.Dal.Concrete.EntityFramework;
using Kormetal.Interfaces;
using Ninject;

namespace Kormetal.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            AddBllBindings();

            //AddServiceBindings();
        }

        private void AddServiceBindings()
        {
            //_kernel.Bind<IIcerikService>().ToConstant(WcfProxy<IIcerikService>.CreateChannel());
            _kernel.Bind<IKategoriService>().ToConstant(WcfProxy<IKategoriService>.CreateChannel());
        }

        private void AddBllBindings()
        {
            _kernel.Bind<IIcerikService>().
                To<IcerikManager>().WithConstructorArgument("icerikDal", new EfIcerikDal());
            _kernel.Bind<IKategoriService>().
                To<KategoriManager>().WithConstructorArgument("kategoriDal", new EfKategoriDal());
            _kernel.Bind<IIcerikResimService>().
               To<IcerikResimManager>().WithConstructorArgument("icerikResimDal", new EfIcerikResimDal());
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}