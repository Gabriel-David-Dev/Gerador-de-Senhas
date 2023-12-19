namespace GeradorDeSenha
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            // Gera um número aleatório de 0 a 9
            int numeroAleatorio = random.Next(0, 10);

            // Gera uma letra aleatória de 'A' até 'Z' maiuscula e depois minuscula
            char letraAleatoria = (char)('A' + random.Next(26));
            string maiuscula = letraAleatoria.ToString().ToUpper();

            letraAleatoria = (char)('A' + random.Next(26));
            string minuscula = letraAleatoria.ToString().ToLower();

            // Gera um caractere especial aleatório: ! @ # $ % ^ & * ( ) _ + - = { } [ ] | \ : ; " ' < > , . ? /
            string[] caracteresEspeciais = new string[30];
            caracteresEspeciais = "! @ # $ % ^ & * ( ) _ + - = { } [ ] | \\ : ; \" ' < > , . ? /".Split(' ');
            int caractereEspecialAleatorio = random.Next(0, 30);
            string caractereEscolhido = caracteresEspeciais[caractereEspecialAleatorio];

            // Cria a base da senha com os elementos fundamentais
            string senha = maiuscula + minuscula + caractereEscolhido + numeroAleatorio;

            // Exibe a senha
            Console.WriteLine($"Senha gerada: {senha}");

        }
    }
}
