using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Scrabble.Models
{
    public class Game {
        Dictionary<int,char[]> LetterScores {get;}
        public Game()
        {
            LetterScores = new Dictionary<int, char[]>();
            LetterScores.Add(1, new char[]{'a','e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'});
        }

        public bool CheckInput(string input)
        {
            Regex reg = new Regex(@"[^A-Za-z]");
            if(reg.IsMatch(input))
            {
               return false; 
            }
            return true;
        }

        public string CheckMultipleWords(string input)
        {
            input = input.Trim();
            if(input.IndexOf(" ")!= -1)
            {
                return input.Substring(0, input.IndexOf(" "));
            }
            
            return input; 
        }

        public int LetterScore(char letter)
        {
            int score = LetterScores.Where(pair => pair.Value.Contains(letter)).FirstOrDefault().Key;
            return score;
        }

    }
}