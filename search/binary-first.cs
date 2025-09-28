class Solution {
    public int binarysearch(int[] arr, int k) {
        // code here
        return Helper(arr, k, 0, arr.Length-1);
    }
    
    private int Helper(int[] arr, int k, int left, int right){
        int res = -1;
        while(left <= right){
            int mid = left + (right-left)/2;
            if(arr[mid] == k){
                res = mid;
                right = mid - 1;
            }
            else if(arr[mid] > k) right = mid - 1;
            else left = mid + 1;
        }
        
        return res;
    }
}