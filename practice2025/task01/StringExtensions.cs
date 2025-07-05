namespace task01;

public static class StringExtensions
{
	public static bool IsPalindrome(this string input)
	{
		string processing = input.ToLower();
		processing = new string(processing.Where(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c)).ToArray());

		if (processing == "") return false;

		return processing == new string(processing.Reverse().ToArray());
	}
}