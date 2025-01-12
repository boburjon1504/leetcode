public class MagicDictionary {
    private string[] words;
    public MagicDictionary() {
        
    }
    
    public void BuildDict(string[] dictionary) {
        words = dictionary;
    }
    
    public bool Search(string searchWord) {
        var diff = 101;
        foreach(var word in words){
            if(word.Length != searchWord.Length){
                continue;
            }
            var c = 0;
            for(var i = 0; i < word.Length; i++){
                if(word[i] != searchWord[i]){
                    c++;
                }
            }
            if(c > 0 && diff > c){
                diff = c;
            }
        }

        return diff == 1;
    }
}

/**
 * Your MagicDictionary object will be instantiated and called as such:
 * MagicDictionary obj = new MagicDictionary();
 * obj.BuildDict(dictionary);
 * bool param_2 = obj.Search(searchWord);
 */