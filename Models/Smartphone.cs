using System.Reflection.Metadata.Ecma335;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string modelo;
        private string imei;
        private int memoria;

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public string Modelo {
            get => modelo;

            set
            {
                if (value == "")
                {
                    throw new Exception("O modelo não pode ser vazio!");
                }
                modelo = value;
            }
        }

        public string Imei
        {
            get => imei;

            set
            {
                if (value == "")
                {
                    throw new Exception("O IMEI não pode ser vazio!");
                }
                imei = value;
            }
        }

        public int Memoria
        { 
            get => memoria;

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Essa memoria não existe!");
                }
                memoria = value;
            }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}