using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using BaseballScore.Models;

namespace BaseballScore.Hubs
{
    public interface IScoreHub
    {
        //public Task SendMessage(GamePreview game);
        Task GameAdded(BaseballModel game); //GameModel game
        Task GameDeleted(IEnumerable<BaseballModel> games);
        Task GameUpdated(BaseballModel game);
    }
    public class ScoreHub : Hub<IScoreHub>
    {

    }
}
