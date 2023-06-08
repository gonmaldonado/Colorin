using Colorin.Helpers;

namespace Colorin.Models
{
    public class MainModel
    {
       
        public Domain.Move MakeMove(int level)
        {
            Domain.Move move = new Domain.Move();
            move.Objective = Game.GetNumber();
            move.Color = Game.GetColor(move.Objective, level);
            return move;

        }
    public Domain.Partida MakeMatch(Domain.Partida partida, Domain.Move movimiento)
        {
            partida.Score = Game.Score(partida.Score, Game.Validation(movimiento.Objective, (int)partida.Selection));
            partida.Selection = null;
            return partida;
        }


    }
}
