namespace Teste
{
    public abstract class Atividade
    {
        public static double subtrair(int v1, int v2){
            return v1-v2;
        }
        
        public static string multiplicar(int v1, int v2){
            return "O resultado é " + (v1*v2);
        }
    }
}