namespace ExemploHerancaVeiculo.Entities
{
    class Moto : Veiculo
    {
        public string Tipo { get; set; }
        private double _vlImposto;


        public Moto(string nome, string cor, string fabricante, int ano, char importado, double preco, string tipo)
            : base(nome, cor, fabricante, ano, importado, preco)
        {
            Tipo = tipo;
        }

        public override double CalculaImposto()
        {
            if (Preco < 5000)
            {
                _vlImposto = Preco * 0.03;
            }
            else if (Preco >= 5000 && Preco < 10000)
            {
                _vlImposto = Preco * 0.05;
            }
            else if (Preco >= 10000 && Importado == 'N')
            {
                _vlImposto = Preco * 0.1;
            }
            else
            {
                _vlImposto = Preco * 0.2;
            }
            return _vlImposto;
        }
    }
}
