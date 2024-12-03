
using AutoMapper;
using IFSPStore.App.Cadastros;
using IFSPStore.App.Models;
using IFSPStore.App.Outros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServiceProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco de Dados
            //Configura Banco na injeção de dependencia
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");

            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            #endregion

            #region Formulários
            Services.AddTransient<Login,Login>();
            Services.AddTransient<CadastroCidade, CadastroCidades>();
            #endregion

            #region Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cidade, Cidade>();
                config.CreateMap<Cidade, CidadeModel>()
                .ForMember(c => c.NomeEstado, c => c.MapFrom(x => $"{x.Nome}/{x.Estado}"));

                config.CreateMap<Cliente, ClienteModel>()
                .ForMember(c => c.Cidade, c=>c.MapFrom(x=>$"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                .ForMember(c=>c.IdCidade, c => c.MapFrom(x=> x.Cidade!.Id));

            }).CreateMapper());
            #endregion

            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}
