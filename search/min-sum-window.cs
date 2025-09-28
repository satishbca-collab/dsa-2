public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, right = 0, minLen = Int32.MaxValue, sum = 0;

        // Why left <= right is required?
        while(left <= right && right < nums.Length){
            sum += nums[right];
            while(sum >= target){
                minLen = Math.Min(minLen, right - left + 1);
                sum -= nums[left];
                left++;
            }
            right++;
        }
        return minLen == Int32.MaxValue ? 0 : minLen;
    }
}