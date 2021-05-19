namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor;
        
        public float tamanho;
        
        public string modelo;

        public bool ld;

        public bool Ligado(){
            ld = true;
            return ld;
        }
        public bool Desligado(){
            ld = false;
            return ld;
        }
        public string LigarNumero(){
            return "chamando...";
        }
        public string EnviarMensagem(){
            return "mensagem enviada com sucesso!";
        }
    }
    
}