using ApiCatalogoJogos_1.InputModel;
using ApiCatalogoJogos_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos_1.Service
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid idJogo);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid idJogo, JogoInputModel jogo);
        Task Atualizar(Guid idJogo, double preco);
        Task Remover(Guid idJogo);
    }
}
