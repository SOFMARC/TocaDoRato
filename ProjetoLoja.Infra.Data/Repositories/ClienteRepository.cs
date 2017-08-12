﻿using ProjLoja.Domain.Entities;
using ProjLoja.Domain.Interfaces;
using ProjLoja.Infra.Data.Repositories;
using ProLoja.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoja.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
