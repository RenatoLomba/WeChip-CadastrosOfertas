using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WeChip_CadastrosOfertas.Repository.implementations;
using WeChip_CadastrosOfertas.Repository.interfaces;

namespace WeChip_CadastrosOfertas.Repository.injection
{
    public class ConfigureDependencyInjection
    {
        public static void Configuration(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IClienteRepository), typeof(ClienteRepository));
            serviceCollection.AddScoped(typeof(IStatusRepository), typeof(StatusRepository));
            serviceCollection.AddScoped(typeof(IProdutoRepository), typeof(ProdutoRepository));
            serviceCollection.AddScoped(typeof(IEnderecoRepository), typeof(EnderecoRepository));
            serviceCollection.AddScoped(typeof(IOfertaRepository), typeof(OfertaRepository));
            serviceCollection.AddScoped(typeof(IProdutoOfertaRepository), typeof(ProdutoOfertaRepository));
        }
    }
}
