namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é menor do que o número de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {         
            return Hospedes.Count; 
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                decimal desconto = 0.1M; 

                valor = valor * (1 - desconto);
            }

            return valor;
        }
    }
}