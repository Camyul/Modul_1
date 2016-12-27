

namespace StringBuilder.Substring
{
    using System.Text;
    public static class SbSubstring
    {
        public static StringBuilder Substring(this StringBuilder sb, int startInd, int length)
        {
            var newSb = new StringBuilder();
            string temp = sb.ToString();
            temp = temp.Substring(startInd, length);
            newSb.Append(temp);
            return newSb;
        }
        public static StringBuilder Substring(this StringBuilder sb, int startInd)
        {
            var newSb = new StringBuilder();
            string temp = sb.ToString();
            temp = temp.Substring(startInd);
            newSb.Append(temp);
            return newSb;
        }
    }
}
