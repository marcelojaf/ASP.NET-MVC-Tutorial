using EP.CursoMvc.Domain.Entities;
using EP.CursoMvc.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCpf(string cpf)
        {
            return Db.Clientes.FirstOrDefault(c => c.CPF == cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return Db.Clientes.FirstOrDefault(c => c.Email == email);
        }
    }
}
