using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioSistemHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        
        public Suites Suites{ get; set; }

        public int DiasReservados { get; set; }

        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){

            if(Suites.Capacidade >= hospedes.Count()){
                Hospedes = hospedes;
            }
            else 
            {
                Console.WriteLine("Capacidade não compativel");
            }

        }

        public void CadastrarSuite(Suites suites){
            Suites = suites;
        }

        public int ObterQuantidadeHospedes(){
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria(){
            return Suites.ValorDiaria * DiasReservados;

        }
    }
}