class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        ls = []
        c = 0
        for i in range(len(nums)):
            for j in range(i+1,len(nums)):
                if nums[i] + nums[j] == target:
                    ls.append(i)
                    ls.append(j)
                    c += 1
            if c == 1:
                break
                    
        return ls