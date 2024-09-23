using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioSistemHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobreNome){
            
            Nome = nome;
            SobreNome = sobreNome;
        }


        public string Nome { get; set;}
        public string SobreNome { get;}

        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

    }
}