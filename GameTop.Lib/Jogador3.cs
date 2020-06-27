using GameTop.Interface;

namespace GameTop.Lib
{
public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Messi Chuta \n";
        }

        public string Corre()
        {
            return "Messi Corre \n";
        }

        public string Passe()
        {
            return "Messi Passe \n";
        }
    }
}