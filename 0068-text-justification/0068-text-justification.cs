public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var queue = new Queue<string>();
        var length = 0;
        var ans = new List<string>();
        for(var i = 0; i < words.Length; i++){
            if(length + words[i].Length + queue.Count <= maxWidth){
                queue.Enqueue(words[i]);
                length += words[i].Length;
            }else{
                if(queue.Count == 1){
                    var word = queue.Dequeue().PadRight(maxWidth, ' ');
                    ans.Add(word);
                }else{
                    var spaceCount = maxWidth - length;
                    var wordsCount = queue.Count - 1;
                    var space = spaceCount % wordsCount;
                    var word = new StringBuilder();
                    while(queue.Count > 1){
                        if(space > 0){
                            word.Append($"{queue.Dequeue()}{"".PadLeft(spaceCount / wordsCount + 1,' ')}"); 
                            space--;
                        }else{
                            word.Append($"{queue.Dequeue()}{"".PadLeft(spaceCount / wordsCount,' ')}"); 
                        }
                    }
                    word.Append(queue.Dequeue());
                    ans.Add(word.ToString());
                }
                queue.Clear();
                length = words[i].Length;
                queue.Enqueue(words[i]);  
            }
        }

        var w = new StringBuilder();
        while(queue.Count > 1){
            w.Append($"{queue.Dequeue()} ");
        }
        w.Append(queue.Dequeue());
        ans.Add(w.ToString().PadRight(maxWidth, ' '));

        return ans;
    }
}