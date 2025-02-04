class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        def product(nums, res, i, prev):
            if i == len(nums):
                return 1
            
            pr = prev 
            prod = product(nums, res, i + 1, prev * nums[i])

            res.append(prod * pr)

            return prod * nums[i]
        res = []

        product(nums, res,0, 1)
        
        return res[::-1]
                    
        