namespace Aula06Heranca
{
    public class CPF:Pessoa
    {
        public string cpf;
        public string rg;

        public bool ValidarCPF(){
            if(cpf !=""){
                return true; 
            }
            return false;
        }

        //Mensagem de confirmação do CPF
        public string confirmacaoCPF(){
            if(ValidarCPF() == true){
                return "CPF Válido";
            } 
            return "CPF Inválido";
        
        }
        
    }
}