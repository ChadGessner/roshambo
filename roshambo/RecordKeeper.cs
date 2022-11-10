using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo
{
    public class RecordKeeper
    {
        public Dictionary<string, GameResult[]> GameRecords { get; set; } = new();
        public void CheckGameRecords(string playerName)
        {
            if (!GameRecords.ContainsKey(playerName))
            {
                GameRecords[$"{playerName}"] = new GameResult[0];
            }
        }
        public void AddResult(string playerName, string opponentName, bool? isWinner)
        {
            if(isWinner == null)
            {
                GameRecords[playerName] = GameRecords[playerName].Concat(new GameResult[] { (GameResult)2 }).ToArray();
                GameRecords[opponentName] = GameRecords[opponentName].Concat(new GameResult[] { (GameResult)2 }).ToArray();
                return;
            }
            if (isWinner == true)
            {
                GameRecords[playerName] = GameRecords[playerName].Concat(new GameResult[] { (GameResult)0 }).ToArray();
                GameRecords[opponentName] = GameRecords[opponentName].Concat(new GameResult[] { (GameResult)1 }).ToArray();
                return;
            }
            GameRecords[playerName] = GameRecords[playerName].Concat(new GameResult[] { (GameResult)1 }).ToArray();
            GameRecords[opponentName] = GameRecords[opponentName].Concat(new GameResult[] {(GameResult)0 }).ToArray();
        }
        public string DisplayGameRecords(string playerName)
        {
            int totalGames = GameRecords[playerName].Length ;
            int triumphs = GameRecords[playerName].Where(r => r == (GameResult)0).Count();
            int wasVanquished = GameRecords[playerName].Where(r => r == (GameResult)1).Count();
            int draws = GameRecords[playerName].Where(r => r == (GameResult)2).Count();
            return $"{playerName}'s Total Games: {totalGames}\nGlorious Triumphs: {triumphs}\nDraws: {draws}\nPathetic Defeats: {wasVanquished}\n";
        }
    }
}
