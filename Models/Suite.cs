namespace _04___DESAFIO___RESERVA_DE_HOTEL.Models
{
    public class Suite
    {
        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite
        {
            get => _tipoSuite;

            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("O tipo Suite não pode ser vazio");
                }

                _tipoSuite = value;
            }
        }

        public int Capacidade
        {
            get => _capacidade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A Capacidade deve ser maior que zero");
                }

                _capacidade = value;
            }
        }

        public decimal ValorDiaria
        {
            get => _valorDiaria;

            set
            {
                if (value < 50)
                {
                    throw new ArgumentException("A suite de menor valor é R$50, informe o valor correto de acordo com a suite");
                }

                _valorDiaria = value;
            }
        }
    }
}
