﻿using Autofac;
using Nano.N_Base.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nano.N_Base.Domain.Registration
{
    public class BaseDomainRegistration
    {
        public void Register(ref ContainerBuilder builder, AutofacInstanceContextMode autofacInstanceContextMode)
        {
            List<Type> tiposValidacoes = typeof(BaseDomainRegistration).Assembly.GetTypes().Where(p => p.Name.ToUpper().Contains("SERVICE") && !p.IsInterface && !p.Name.ToUpper().Contains("BASE")).ToList();

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
