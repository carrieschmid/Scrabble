using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Scrabble.Models 
{
    public class Game 
    {
        Dictionary<int, char[]> LetterScores { get; }
        public Game () 
        {
            LetterScores = new Dictionary<int, char[]> ();
            LetterScores.Add (1, new char[] { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' });
            LetterScores.Add (2, new char[] { 'd', 'g' });
            LetterScores.Add (3, new char[] { 'b', 'c', 'm', 'p' });
            LetterScores.Add (4, new char[] { 'f', 'h', 'v', 'w', 'y' });
            LetterScores.Add (5, new char[] { 'k' });
            LetterScores.Add (8, new char[] { 'j', 'x' });
            LetterScores.Add (10, new char[] { 'q', 'z' });
        }

        public bool CheckInput (string input) 
        {
            Regex reg = new Regex (@"[^A-Za-z]");
            if (reg.IsMatch (input)) 
            {
                return false;
            }
            return true;
        }

        public string CheckMultipleWords (string input) 
        {
            input = input.Trim ();
            if (input.IndexOf (" ") != -1) 
            {
                return input.Substring (0, input.IndexOf (" ")).ToLower();
            }

            return input.ToLower();
        }

        public int LetterScore (char letter) 
        {
            int score = LetterScores.Where (pair => pair.Value.Contains (letter)).FirstOrDefault().Key;
            return score;
        }

        public int WordScore(string word)
        {
            int totalScore = 0;
            foreach(char letter in word)
            {
                totalScore = totalScore + LetterScore(letter);
            }
            return totalScore;

        }

    }
}