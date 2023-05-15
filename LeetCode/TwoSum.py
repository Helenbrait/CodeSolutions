# Searching for matching sum of two numbers to target in python

# Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
# You may assume that each input would have exactly one solution, and you may not use the same element twice.
# You can return the answer in any order.

class Solution(object):
    def twoSum(self, nums, target):
        for j in range(len(nums)):
            firstValue = nums[j]
            for i in range(j+1, len(nums)):
                newValue = firstValue+nums[i];
                if (target == newValue):
                    return [i,j]
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
     
