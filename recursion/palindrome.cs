class Solution {
    // Sub-optimal solution
    public bool Palindrome(string s) {
		int n = s.Length;
		if(n <= 1) return true;
		if(s[0] == s[n-1]) return Palindrome(s.Substring(1,n-2));
		return false;
	}
    // Optimal solution
	public bool isPalindrome(string s) {
		int n = s.Length;
		if(n <= 1) return true;
		return Helper(s, 0, n - 1);
	}

	private bool Helper(string s, int left, int right){
		if(left >= right) return true;
		if(s[left] == s[right]) return Helper(s, left + 1, right - 1);
		return false;
	}
}

Solution s = new Solution();
Console.WriteLine(s.isPalindrome(""));
Console.WriteLine(s.isPalindrome("a"));
Console.WriteLine(s.isPalindrome("engine"));
Console.WriteLine(s.isPalindrome("malayalam"));