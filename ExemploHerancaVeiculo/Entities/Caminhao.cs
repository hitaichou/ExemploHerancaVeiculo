
namespace ExemploHerancaVeiculo.Entities
{
    class Caminhao: Veiculo
    {
        public string Tipo { get; set; }
        private double _vlImposto;
        private double _vlPreco;


        public Caminhao(string modelo, string cor, string fabricante, int ano, char importado, double preco/*, string tipo*/)
            : base(modelo, cor, fabricante, ano, importado, preco)
        {
            //Tipo = tipo;
        }

        public override double CalculaPreco()
        {
            if (Preco < 30000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.15);
            }
            else if (Preco < 30000 && Importado == 'S')
            {
                _vlPreco = Preco + (Preco * 0.2);
            }
            else if (Preco >= 30000 && Preco < 60000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.3);
            }
            else if (Preco >= 30000 && Preco < 60000 && Importado == 'S')
            {
                _vlPreco = Preco + (Preco * 0.35);
            }
            else if (Preco >= 60000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.4);
            }
            else
            {
                _vlPreco = Preco + (Preco * 0.45);
            }
            return _vlPreco;
        }

        public override double CalculaImposto()
        {
            if (Preco < 30000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.15;
            }
            else if (Preco < 30000 && Importado == 'S')
            {
                _vlImposto = Preco * 0.2;
            }
            else if (Preco >= 30000 && Preco < 60000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.3;
            }
            else if (Preco >= 30000 && Preco < 60000 && Importado == 'S')
            {
                _vlImposto = Preco * 0.35;
            }
            else if (Preco >= 60000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.4;
            }
            else
            {
                _vlImposto = Preco * 0.45;
            }
            return _vlImposto;
        }
    }
}
