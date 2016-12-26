using EP.CursoMvc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {
        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel obj);
        ClienteViewModel Atualizar(ClienteViewModel obj);
        void Remover(Guid id);
        ClienteViewModel ObterPorId(Guid id);
        ClienteViewModel ObterPorCPF(string cpf);
        ClienteViewModel ObterPorEmail(string email);
        IEnumerable<ClienteViewModel> ObterTodos();
    }
}
