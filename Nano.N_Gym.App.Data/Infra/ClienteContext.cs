﻿using Nano.N_Base.Data.Infra;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Data.Infra
{
    internal class ClienteContext : GymContext<Cliente>, IClienteContext
    {
    }
}
