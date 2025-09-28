public class Solution {
    public int Search(int[] nums, int target) {
        return Helper(nums, target, 0, nums.Length - 1);
    }

    private int Helper(int[] nums, int target, int left, int right){
        if(left > right) return -1;

        int mid = left + (right - left)/2;
        if(nums[mid] == target) return mid;
        else if(nums[mid] > target) return Helper(nums, target, left, mid - 1);
        else return Helper(nums, target, mid + 1, right);
    }
}