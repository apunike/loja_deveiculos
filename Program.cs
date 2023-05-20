using System;
using System.Collections.Generic;
using MeuTrabalho.Motos;
using MeuTrabalho.Revenda;

namespace MeuTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            var moto1 = new Moto
            {
                MarcaDaMoto = new Marca
                {
                    Nome = "Honda",
                    PaisDeOrigem = "Japão"
                },
                PneuDaMoto = new Pneu
                {
                    MarcaDoPneu = new Marca
                    {
                        Nome = "Pirele",
                        PaisDeOrigem = "Japão"
                    },
                    MedidasDoPneu = "180/55/17"
                },
                SeguimentoDaMoto = new Seguimento
                {
                    NomeDoEstilo = "Trail",
                    PaisDeOrigem = "Japão"
                },
                Modelo = "cb500f"
            };

            Console.WriteLine($"==================== \n" +
                                      "Moto 1        \n" +     
                               "==================== \n" +
                              
            $"Marca [[ {moto1.MarcaDaMoto.Nome} ]]\n" +
            $"País de origem [[ {moto1.MarcaDaMoto.PaisDeOrigem} ]] \n" +
            $"Marca do Pneu [[ {moto1.PneuDaMoto.MarcaDoPneu.Nome} ]]\n" +
            $"Seguimento da moto [[ {moto1.SeguimentoDaMoto.NomeDoEstilo} ]]\n" +
             "=======================================" );

            var carro1 = new Carro
            {
                MarcaDoCarro = "chevrolet",
                Modelo = "onix",
                PneuDoCarro = new Pneu
                {
                    MarcaDoPneu = new Marca
                    {
                        Nome = "Diablorosso",
                        PaisDeOrigem = "italia"
                    },
                    MedidasDoPneu = "195/35/15"
                }

            };

            var loja = new LojaDeVeiculo
            {
                Carros = new List<Carro>
                {
                    carro1
                },
                Motos = new List<Moto>
                {
                    moto1
                }
            };

       }
    }

}



