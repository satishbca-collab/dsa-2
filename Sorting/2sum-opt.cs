public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement)) {
                return new int[] { numIndices[complement], i };
            }

            if (!numIndices.ContainsKey(nums[i])) {
                numIndices[nums[i]] = i;
            }
        }

        throw new Exception("No two sum solution");
    }
}