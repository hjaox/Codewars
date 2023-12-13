/*
https://www.codewars.com/kata/57613fb1033d766171000d60/train/csharp



Finish the uefaEuro2016() function so it return string just like in the examples below:

uefaEuro2016(['Germany', 'Ukraine'],[2, 0]) // "At match Germany - Ukraine, Germany won!"
uefaEuro2016(['Belgium', 'Italy'],[0, 2]) // "At match Belgium - Italy, Italy won!"
uefaEuro2016(['Portugal', 'Iceland'],[1, 1]) // "At match Portugal - Iceland, teams played draw."
*/

namespace CSharp._8kyu;

public class UEFAEURO2016 {
    public static string UefaEuro2016(string[] teams, int[] scores) {
        int winner = scores[0] > scores[1] ? 0
        :scores[0] < scores[1] ? 1
        :3;

        return winner != 3 ? $"At match {teams[0]} - {teams[1]}, {teams[winner]} won!"
        : $"At match {teams[0]} - {teams[1]}, teams played draw.";
    }
}