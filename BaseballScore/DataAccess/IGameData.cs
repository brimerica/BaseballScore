using BaseballScore.Models;
using System;
using System.Collections.Generic;

namespace BaseballScore.DataAccess
{
    public interface IGameData
    {
        void AddGame(BaseballModel newGame);
        void DeleteGame(Guid Id);
        BaseballModel GetGame(Guid Id);
        IEnumerable<BaseballModel> GetGames();
        void UpdateGame(BaseballModel updatedGame);
    }
}