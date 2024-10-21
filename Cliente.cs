using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplasJanelas
{
    public class Cliente
    {

        [DisplayName("Id")] public int Id { get; set; }    
        [DisplayName("Nome do Cliente")] public string Nome { get; set; }
        [DisplayName("Número de Telefone")] public string Fone { get; set; }
        [DisplayName("Endereço de E-mail")] public string Email { get; set; }
        [DisplayName("Endereço Pessoal")] public string Endereco { get; set; }

        public void loadData(string dataString)
        {
            string[] data = dataString.Split(';');
            Id = int.Parse(data[0]);
            Nome = data[1];
            Fone = data[2];
            Email = data[3];
            Endereco = data[4];
        }
        public override string ToString()
        {
            return $"{Id};{Nome};{Fone};{Email};{Endereco}";
        }
    }
}
