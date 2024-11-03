class Solution:
    def rotateString(self, s: str, goal: str) -> bool:
        c = 0
        s = list(s)
        while c!= len(s):
            s += s[0]
            s.pop(0)
            if "".join(s) == goal:
                return True
            c += 1
        return False
        
        