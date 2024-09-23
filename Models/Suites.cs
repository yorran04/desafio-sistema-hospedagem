using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioSistemHospedagem.Models
{
    public class Suites
    {
        public Suites(string tipoSuite, int capacidade, decimal valorDiaria){
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

      

        public string TipoSuite { get; set;}
        public int Capacidade { get;}
        public decimal ValorDiaria { get;}

       
    }
}