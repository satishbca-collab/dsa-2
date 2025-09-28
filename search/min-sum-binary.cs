public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length;
        if(n == 0) return 0;

        int minLength = Int32.MaxValue;

        int left = 1, right = n;

        while(left <= right){
            int mid = left + (right-left)/2;

            if(ValidSubArray(nums, target, mid)){
                minLength = mid;
                right = mid - 1;
            }
            else {
                left = mid + 1
            }
        }

        return (minLength == Int32.MaxValue ? 0 : minLength);
    }

    private bool ValidSubArray(int[] nums, int target, int len){
        int sum = 0;

        for(int i = 0; i < len; i++){
            sum += nums[i];
        }

        if(sum >= target) return true;

        for(int i = len; i < nums.Length; i++){
            sum += nums[i] - nums[i - len];
            if(sum >= target) return true;
        }

        return false;    }
}