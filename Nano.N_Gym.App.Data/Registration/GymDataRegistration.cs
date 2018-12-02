using Autofac;
using Nano.N_Base.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nano.N_Gym.App.Data.Registration
{
    public class GymDataRegistration
    {
        public void Register(ref ContainerBuilder builder, AutofacInstanceContextMode autofacInstanceContextMode)
        {
            List<Type> tiposRepositoriosEContextos = typeof(GymDataRegistration).Assembly.GetTypes().Where(p => (p.Name.ToUpper().Contains("REPOSITORY") || p.Name.ToUpper().Contains("CONTEXT")) && !p.IsInterface && !p.Name.ToUpper().Contains("BASE") && !p.Name.ToUpper().Contains("GYM")).ToList();

            ContainerBuilder tempBuilder = builder;

            switch (autofacInstanceContextMode)
            {
                case AutofacInstanceContextMode.PerCall:
                    tiposRepositoriosEContextos.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces());
                    break;
                case AutofacInstanceContextMode.PerHttpRequest:
                    tiposRepositoriosEContextos.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces().InstancePerRequest());
                    break;
                case AutofacInstanceContextMode.PerLifetimeScope:
                    tiposRepositoriosEContextos.ForEach(p => tempBuilder.RegisterType(p).AsImplementedInterfaces().InstancePerLifetimeScope());
                    break;
            }

            builder = tempBuilder;
        }
    }
}
