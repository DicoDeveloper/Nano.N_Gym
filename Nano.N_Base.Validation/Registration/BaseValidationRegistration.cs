using Autofac;
using Nano.N_Base.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nano.N_Base.Validation.Registration
{
    public class BaseValidationRegistration
    {
        public void Register(ref ContainerBuilder builder, AutofacInstanceContextMode autofacInstanceContextMode)
        {
            List<Type> tiposValidacoes = typeof(BaseValidationRegistration).Assembly.GetTypes().Where(p => p.Name.ToUpper().Contains("VALIDATION") && !p.IsInterface && !p.Name.ToUpper().Contains("BASE")).ToList();

            ContainerBuilder tempBuilder = builder;

            switch (autofacInstanceContextMode)
            {
                case AutofacInstanceContextMode.PerCall:
                    tiposValidacoes.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces());
                    break;
                case AutofacInstanceContextMode.PerHttpRequest:
                    tiposValidacoes.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces().InstancePerRequest());
                    break;
                case AutofacInstanceContextMode.PerLifetimeScope:
                    tiposValidacoes.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces().InstancePerLifetimeScope());
                    break;
            }

            builder = tempBuilder;
        }
    }
}
