namespace _04___DESAFIO___RESERVA_DE_HOTEL.Models
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;

        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }

        public string Nome
        {
            get => _nome;

            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("O Nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string SobreNome
        {
            get => _sobrenome;

            set
            {
                if (value.Trim() == "")
                {
                    throw new ArgumentException("O SobreNome não pode ser vazio");
                }

                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();
    }
}
