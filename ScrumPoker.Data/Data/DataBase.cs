using ScrumPoker.Core.Models;

namespace ScrumPoker.Data.Data;

public static class DataBase
{
    public static List<Player> Players = new List<Player>();
    public static List<GameRoom> GameRooms = new List<GameRoom>();
    public static List<VotingResults> VotingResults = new List<VotingResults>();
}