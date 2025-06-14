public class Solution {
    public int MinMaxDifference(int num) {
        var str = num.ToString();

        if(str.All(c => c == '9')){
            return num;
        }

        var notNine = str.First(c => c != '9');

        var max = int.Parse(str.Replace(notNine, '9'));
        var min = int.Parse(str.Replace(str[0], '0'));

        Console.WriteLine($"{notNine}   {max}  {min}");

        return max - min;
    }
}