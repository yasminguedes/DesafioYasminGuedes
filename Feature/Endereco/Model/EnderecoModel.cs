namespace ProjetoDesafio.Feature.Endereco.Model
{
    public class EnderecoModel
    {
        public int IdEndereco { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public void SelecionaEstado()
        {
            if (Estado.Equals("SP"))
            {
                Cidade = @"Jales, Urania, São José do Rio Preto, São Paulo, Santa Fé do Sul";
            }

            if (Estado.Equals("MS"))
            {
                Cidade = @"Antonio Joao,Aparecida do Taboado,Aquidauana,Aral Moreira,Bandeirantes,Bataguassu,Bataipora,Bela Vista,
                            Bodoquena,Bonito,Brasilandia,Caarapo,Camapua,Campo Grande,Caracol,Cassilandia,Chapadao do Sul,Corguinho,
                            Coronel Sapucaia,Corumba,";
            }            
        }
    }
}
