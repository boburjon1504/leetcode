public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        var dict = new Dictionary<string, int>();

        foreach(var cDomain in cpdomains){
            var pair = cDomain.Split();
            var count = int.Parse(pair[0]);
            var domain = pair[1];

            while(domain.Any(d => d == '.')){
                if(!dict.ContainsKey(domain)){
                    dict[domain] = 0;
                }
                dict[domain] += count;

                var firstDot = domain.IndexOf('.');
                domain = domain.Substring(firstDot + 1);
            }

            if(!dict.ContainsKey(domain)){
                dict[domain] = 0;
            }

            dict[domain] += count;
        }

        var res = new List<string>();

        foreach(var (key, val) in dict){
            res.Add($"{val} {key}");
        }

        return res;
    }
}