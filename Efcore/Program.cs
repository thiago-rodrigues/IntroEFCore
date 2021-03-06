﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Efcore.Domain;
using Efcore.ValueObjects;

namespace Efcore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Data.ApplicationContext();
            var existe = db.Database.GetPendingMigrations().Any();
            if(existe){
                
            }
            //InserirDados();                        
            InserirDadosEmMassa();
        }
        private static void InserirDados(){
            var produto = new Produto{
                  Descricao = "Produto Teste",
                  CodigoBarras = "1232654654",
                  Valor = 10m,
                  TipoProduto = TipoProduto.MercadoriaParaRevenda,
                  Ativo = true
            };

            using var db = new Data.ApplicationContext();
            
            db.Produto.Add(produto);
            db.Set<Produto>().Add(produto);
            db.Entry(produto).State = EntityState.Added;
            db.Add(produto);

            var registros = db.SaveChanges();
            Console.WriteLine($"Total de registros Inseridos: {registros}");

        }
        private static void InserirDadosEmMassa(){
            var listaCliente = new []{

                new Cliente {
                    Nome = "Thiago Ribeiro",
                    CEP = "39400000",
                    Cidade = "Montes Claros",
                    Estado = "MG",
                    Telefone = "8798798989"                
                },
                new Cliente {
                    Nome = "Thiago Ribeiro Rodrigues",
                    CEP = "39400000",
                    Cidade = "Montes Claros",
                    Estado = "MG",
                    Telefone = "8798798989"                
                }
            };
            using var db =  new Data.ApplicationContext();
            
            db.Cliente.AddRange(listaCliente);
            var registros = db.SaveChanges();
            Console.WriteLine($"Total de Registros Inseridos: {registros}");
        
        }
    }
}
