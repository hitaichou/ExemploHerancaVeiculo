using ExemploHerancaVeiculo.Entities.Exceptions;
namespace ExemploHerancaVeiculo.Entities
{
    class Moto : Veiculo
    {
        public string Tipo { get; set; }
        private double _vlImposto;
        private double _vlPreco;


        public Moto(string modelo, string cor, string fabricante, int ano, char importado, double preco/*, string tipo*/)
            : base(modelo, cor, fabricante, ano, importado, preco)
        {
            //Tipo = tipo;
        }

        public override double CalculaPreco()
        {
            if (Preco < 5000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.05);
            }
            else if (Preco < 5000 && Importado == 'S')
            {
                _vlPreco = Preco + (Preco * 0.1);
            }
            else if (Preco >= 5000 && Preco < 10000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.1);
            }
            else if (Preco >= 5000 && Preco < 10000 && Importado == 'S')
            {
                _vlPreco = Preco + (Preco * 0.15);
            }
            else if (Preco >= 10000 && Importado == 'N')
            {
                _vlPreco = Preco + (Preco * 0.2);
            }
            else if (Preco >= 10000 && Importado == 'S')
            {
                _vlPreco = Preco + (Preco * 0.3);
            }
            else
            {
                throw new DomainException("Não existe este tipo de importado.");
            }
            return _vlPreco;
        }

        public override double CalculaImposto()
        {
            if (Preco < 5000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.05;
            }
            else if (Preco < 5000 && Importado == 'S')
            {
                _vlImposto = Preco * 0.1;
            }
            else if (Preco >= 5000 && Preco < 10000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.1;
            }
            else if (Preco >= 5000 && Preco < 10000 && Importado == 'S')
            {
                _vlImposto = Preco * 0.15;
            }
            else if (Preco >= 10000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.2;
            }
            else if (Preco >= 10000 && Importado == 'S')
            {
                _vlImposto = Preco * 0.3;
            }
            else
            {
                throw new DomainException("Não existe este tipo de importado.");
            }
            return _vlImposto;
        }
    }
}
