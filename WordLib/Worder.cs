namespace WordLib
{
    public class Worder
    {
        public bool Palindrome(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new Exception("No data in input string");
            }

            string reversed = new string(input.ToLower().ToCharArray().Reverse().ToArray());

            if (input.Equals(reversed))
            {
                return true;
            }

            return false;
        }

        public bool FiveOrMoreChar(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new Exception("No data in input string");
            }

            if (input.Length >= 5)
            {
                return true;
            }

            return false;
        }
    }
}