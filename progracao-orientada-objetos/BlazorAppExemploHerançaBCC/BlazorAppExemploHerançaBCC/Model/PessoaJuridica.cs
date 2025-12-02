namespace BlazorAppExemploHerançaBCC.Model
{
    public class PessoaJuridica:Pessoa
    {
        private string cnpj;
        private string inscricaoEstadual;
        private string inscricaoMunicipal;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public string InscricaoMunicipal { get => inscricaoMunicipal; set => inscricaoMunicipal = value; }
    }
}
