using Autofac;
using Nano.N_Base.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nano.N_Gym.App.Domain.Registration
{
    public class GymDomainRegistration
    {
        public void Register(ref ContainerBuilder builder, AutofacInstanceContextMode autofacInstanceContextMode)
        {
            List<Type> tiposServicos = typeof(GymDomainRegistration).Assembly.GetTypes().Where(p => p.Name.ToUpper().Contains("SERVICE") && !p.IsInterface && !p.Name.ToUpper().Contains("BASE") && !p.Name.ToUpper().Contains("GYM")).ToList();

            ContainerBuilder tempBuilder = builder;

            switch (autofacInstanceContextMode)
            {
                case AutofacInstanceContextMode.PerCall:
                    tiposServicos.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces());
                    break;
                case AutofacInstanceContextMode.PerHttpRequest:
                    tiposServicos.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces().InstancePerRequest());
                    break;
                case AutofacInstanceContextMode.PerLifetimeScope:
                    tiposServicos.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces().InstancePerLifetimeScope());
                    break;
            }

            builder = tempBuilder;
        }
    }
}
