namespace GeradorDeSenha
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> senhas = new List<string>();

            Random random = new Random();

            while (true)
            {
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

                // Completando a senha de forma aleatória
                for (int contador = 0; contador < 6; contador++)
                {
                    int opcao = random.Next(0, 4);
                    switch (opcao)
                    {
                        case 0:
                            senha += random.Next(0, 10);
                            break;
                        case 1:
                            var letraMaiuscula = (char)('A' + random.Next(26));
                            senha += letraMaiuscula.ToString().ToUpper();
                            break;
                        case 2:
                            var letraMinuscula = (char)('A' + random.Next(26));
                            senha += letraMinuscula.ToString().ToLower();
                            break;
                        case 3:
                            senha += caracteresEspeciais[random.Next(0, 30)];
                            break;
                    }
                }

                // Garantindo que essa é uma senha que nunca foi criada e exibindo
                if (!senhas.Contains(senha))
                {
                    // Exibindo a senha gerada
                    senhas.Add(senha);
                    Console.WriteLine(senha);
                    break;
                }
            }
        }
    }
}
