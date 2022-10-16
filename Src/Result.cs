namespace Src
{
    public class Result
    {
        /*
        * Complete the 'matchingStrings' function below.
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts following parameters:
        *  1. STRING_ARRAY strings
        *  2. STRING_ARRAY queries
        */

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> resultList = new List<int>();

            foreach (var qrs in queries)
            {
                List<string> filter = strings.Where(str => Equals(str, qrs)).ToList();
                resultList.Add(filter.Count());
            }
            
            return resultList;
        }
    }
}