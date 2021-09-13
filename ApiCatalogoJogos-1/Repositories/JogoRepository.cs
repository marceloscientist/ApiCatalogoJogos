using ApiCatalogoJogos_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos_1.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private static Dictionary<Guid, Jogo> jogos = new Dictionary<Guid, Jogo>()
        {
            {Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd04"), new Jogo { Id = Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd04"), Nome = "Fifa 21", Produtora = "EA", Preco = 200} },
            {Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd03"), new Jogo { Id = Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd03"), Nome = "Pipa 21", Produtora = "TE", Preco = 150} },
            {Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd05"), new Jogo { Id = Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd05"), Nome = "Xinxa 21", Produtora = "pI-EA", Preco = 250} },
            {Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd07"), new Jogo { Id = Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd07"), Nome = "Mica 21", Produtora = "Ag", Preco = 3000} },
            {Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd09"), new Jogo { Id = Guid.Parse("0ca314a5-9282-45d8-92c3-2985f2a9fd09"), Nome = "Tita 21", Produtora = "uEAU", Preco = 100} }
        };
        public Task<List<Jogo>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(jogos.Values.Skip((pagina - 1) * quantidade).Take(quantidade).ToList());
        }

        public Task<Jogo> Obter(Guid id)
        {
            if (!jogos.ContainsKey(id))
                return null; // Task.FromResult(
            return Task.FromResult(jogos[id]);
        }

        public Task<List<Jogo>> Obter(string nome, string produtora)
        {
            return Task.FromResult(jogos.Values.Where(jogo => jogo.Nome.Equals(nome) && jogo.Produtora.Equals(produtora)).ToList());
        }

        public Task Inserir(Jogo jogo)
        {
            jogos.Add(jogo.Id, jogo);
            return Task.CompletedTask;

        }

        public Task Atualizar(Jogo jogo)
        {
            jogos[jogo.Id] = jogo;
            return Task.CompletedTask;
        }
        public Task Remover(Guid id)
        {
            jogos.Remove(id);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            // fechar conexão com o banco
        }

    }
}
