using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02_POO
{
    /// <summary>
    /// Aqui criou uma classe
    /// Foi criado um encapsulamento
    /// </summary>
    public class CentroDeCusto
    {
        public int Id { get; set; } //defaut 0
        public string Descricao { get; set; } // null
        public DateTime DataCriacao { get; set; }//01/01/1900 00:00
        public decimal VerbaLiberada { get; set; }//0.0
        public int AnoVerbaLiberada { get; set; }

        //variavel privada
        private decimal custoReal;

        //construtor com parametros
        public CentroDeCusto(int id, string descricao, DateTime dataCriacao, decimal verbaLiberada, int anoVerbaLiberada)
        {
            /*preencher as propriedades com os
             * parametros recebidos do construtor
             */
            Id = id;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            VerbaLiberada = verbaLiberada;
            AnoVerbaLiberada = anoVerbaLiberada;
        }
        //Novo metodo que vai preeencher a variavel privada chamada custo real com o valor do parametro recebido(custoRealNovo)
        public void CalcularCustoReal(decimal custoRealNovo) {
            custoReal = custoRealNovo;
            Console.WriteLine($"O novo custo real do centro de custo {Descricao}, com o id {Id} é {custoReal} ");
        }
    }
}
