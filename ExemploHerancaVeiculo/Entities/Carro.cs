using ExemploHerancaVeiculo.Entities.Exceptions;
namespace ExemploHerancaVeiculo.Entities
{
    class Carro : Veiculo
    {
        public string Tipo { get; set; }
        private double _vlImposto;
        private double _vlPreco;


        public Carro(string modelo, string cor, string fabricante, int ano, char importado, double preco/*, string tipo*/)
            : base(modelo, cor, fabricante, ano, importado, preco)
        {
            //Tipo = tipo;            
        }

        public override double CalculaPreco()
        {
            if(Preco < 10000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.1);
            }
            else if (Preco < 10000 && Importado == 'S')
            {
                _vlPreco = Preco + (Preco * 0.15);
            }
            else if(Preco >= 10000 && Preco < 40000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.2);
            }
            else if (Preco >= 10000 && Preco < 40000 && Importado == 'S')
            {
                _vlPreco = Preco + (Preco * 0.25);
            }
            else if (Preco >= 40000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.30);
            }
            else if (Preco >= 40000 && Importado == 'S')
            {
                _vlPreco = Preco + (Preco * 0.35);
            }
            else
            {
                throw new DomainException("Não existe este tipo de importado.");
            }
            return _vlPreco;
        }

        public override double CalculaImposto()
        {
            if (Preco < 10000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.1;
            }
            else if (Preco < 10000 && Importado == 'S')
            {
                _vlImposto = Preco * 0.15;
            }
            else if (Preco >= 10000 && Preco < 40000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.2;
            }
            else if (Preco >= 10000 && Preco < 40000 && Importado == 'S')
            {
                _vlImposto = Preco * 0.25;
            }
            else if (Preco >= 40000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.30;
            }
            else if (Preco >= 40000 && Importado == 'S')
            {
                _vlImposto = Preco * 0.35;
            }
            else
            {
                throw new DomainException("Não existe este tipo de importado.");
            }
            return _vlImposto;
        }
    }
}
