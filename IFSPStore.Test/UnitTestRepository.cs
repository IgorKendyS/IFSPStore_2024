using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IFSPStore.Test
{
    [TestClass]

    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Cidade> Cidades { get; set; }
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Grupo> Grupos { get; set; }
            public DbSet<Produto> Produtos { get; set; }
            public DbSet<Venda> Vendas { get; set; }
            public DbSet<VendaItem> VendaItens { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var password = "ifsp2024";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]

        public void TestInsertCidade()
        {
            using(var context = new MyDbContext())
            {
                var cidade = new Cidade
                {
                    Nome = "Birigui",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                cidade = new Cidade
                {
                    Nome = "Araçatuba",
                    Estado = "SP"
                };
                context.Cidades.Add(cidade);

                context.SaveChanges();
            }
            
        }
        [TestMethod]
        public void TestListCidades()
        {
            using(var context = new MyDbContext())
            {
                foreach(var cidade in context.Cidades)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cidade));
                }
            }
        }

        /*[TestMethod]

        public void TestDeleteCidade()
        {
            using(var context = new MyDbContext())
            {
                var cidade = context.Cidades.FirstOrDefault(c => c.Nome == "Birigui" && c.Estado == "SP");
                if (cidade != null)
                {
                    context.Cidades.Remove(cidade);
                    context.SaveChanges();
                }
                
            }
        }*/

        [TestMethod]

        public void TestInsertUsuario()
        {
            using (var context = new MyDbContext())
            {
                var usuario = new Usuario(
                    "Igor Sakaguchi",         // Nome
                    "12345",                  // Senha
                    "igorifsp",               // Login
                    "s.kendy@aluno.ifsp.edu.br", // Email
                    DateTime.Now, // DataCadastro
                    DateTime.Now, // DataLogin
                    true                      // Ativo
                );
                context.Usuarios.Add(usuario);

                context.SaveChanges();
            }

        }

        [TestMethod]
        public void TestListUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }

        [TestMethod]
        public void TestInsertGrupo()
        {
            using (var context = new MyDbContext())
            {
                var grupo = new Grupo { 
                   Nome = "Doces"
                };
                context.Grupos.Add(grupo);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListGrupos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var grupo in context.Grupos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(grupo));
                }
            }
        }

        [TestMethod]
        public void TestInsertProdutos()
        {
            using(var context = new MyDbContext())
            {
                var grupo = context.Grupos.FirstOrDefault(c => c.Nome == "Doces");
                
                    if(grupo != null) {
                        var produtos = new Produto
                        {
                            Nome = "Chocolate",
                            Preco = 11.92f,
                            Quantidade = 1,
                            DataCompra = DateOnly.FromDateTime(DateTime.Now),
                            UnidadeVenda = "gramas",
                            Grupo = grupo
                        };
                        context.Produtos.Add(produtos);
                        context.SaveChanges();
                    }
                
            }
        }

        [TestMethod]

        public void TestListProdutos()
        {
            using( var context = new MyDbContext())
            {
                foreach(var produto in context.Produtos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(produto));
                }
            }
        }

        [TestMethod]

        public void TestInsertClientes()
        {
            using(var context = new MyDbContext())
            {
                var cidade = context.Cidades.FirstOrDefault(c => c.Nome == "Birigui");
                if(cidade != null)
                {
                    var cliente = new Cliente(
                    "Reginaldo Rossi",
                    "Rua Padre Geraldo",
                    "Jardim Pérola",
                    "45684465917",
                    cidade);
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                }
            }
        }

        [TestMethod]
        public void TestListClientes()
        {
            using(var context = new MyDbContext())
            {
                foreach(var cliente in context.Clientes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cliente));
                }
            }
        }

        [TestMethod]
        public void TestInsertVenda()
        {
            using(var context = new MyDbContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(c => c.Nome == "Reginaldo Rossi");
                var cliente = context.Clientes.FirstOrDefault(c => c.Nome == "Igor Sakaguchi");
                
                if(usuario != null && cliente != null)
                {
                    var venda = new Venda()
                    {
                        Data = DateTime.Now,
                        ValorTotal = 223.80f,
                        Usuario = usuario,
                        Cliente = cliente               
                        
                    };

                    var produto = context.Produtos.FirstOrDefault(c => c.Id == 1);
                    if(produto != null)
                    {
                        venda.Items.Add(new VendaItem
                        {
                            Produto = produto,
                            Quantidade = 10,
                            ValorUnitario = 16.90f,
                            ValorTotal = 169.00f,
                            Venda = venda
                        });
                    }
                    
                }
            }
        }
    }
}
