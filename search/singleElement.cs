public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int l = 0, r = nums.Length - 1;
        while (l < r){
            int mid = l + (r -  l)/2;
            if(mid % 2 == 1){
                mid-=1;
            }

            if(nums[mid] == nums[mid+1]){
                l = mid + 2;
            }
            else {
                r = mid;
            }
        }
        return nums[l];
    }
}