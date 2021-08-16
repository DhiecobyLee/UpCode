using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCodeBank
{
    class Animal
    {
        public Animal(string nome)
        {
            NomeAnimal = nome;
        }
        public Animal (string nome, Cliente cliente, TipoAnimal tipo)
        {
            NomeAnimal = nome;

        }

        private string _nomeAnimal;
     
        public string NomeAnimal {get;set;}

        Cliente dono;
        TipoAnimal tipoAnimal; // enum
    }
}
