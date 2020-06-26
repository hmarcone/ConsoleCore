using System;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly IJogador _iJogadorA;
        private readonly IJogador _iJogadorB;

        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            _iJogadorA = jogador1;
            _iJogadorB = jogador2;
        }

        public void IniciarJogo()
        {
            Console.Write(_iJogadorA.Passe());
            Console.Write(_iJogadorA.Chuta());
            Console.Write(_iJogadorA.Corre());

            //
            Console.Write("\n Próximo jogador \n");
            //
            
            Console.Write(_iJogadorB.Corre());
            Console.Write(_iJogadorB.Chuta());
            Console.Write(_iJogadorB.Passe());

        }
    }
}