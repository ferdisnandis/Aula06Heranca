namespace Aula06Heranca
{
    public class CNPJ:Pessoa
    {
        public string cnpj;

        public bool ValidarCNPJ(){
            if(cnpj !=""){
                return true;
            }
            return false;
        }
        //Mensagem de confirmação do CNPJ
        public string confirmacaoCNPJ(){
            if(ValidarCNPJ() == true){
                return "CNPJ Válido";
            } 
            return "CNPJ Inválido";
            
    }
} 
}