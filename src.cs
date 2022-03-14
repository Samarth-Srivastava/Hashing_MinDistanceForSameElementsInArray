
namespace Hashing_MinDistanceForSameElementsInArray
{
    public class Solution
    {
        public int solve(List<int> A)
        {

            int N = A.Count();
            //brute force
            int ans = int.MaxValue;

            // for(int i = 0; i < N; i++){
            //     for(int j = i+1; j < N; j++){
            //         if(A[i] == A[j]){
            //             ans = min(ans, (j-i));
            //         }
            //     }
            // }

            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < N; i++)
            {
                if (dic.ContainsKey(A[i]))
                {
                    dic[A[i]].Add(i);
                }
                else
                {
                    dic.Add(A[i], new List<int> { i });
                }
            }

            foreach (var item in dic)
            {
                if (item.Value.Count() > 1)
                {
                    ans = min(ans, item.Value[1] - item.Value[0]);
                }
            }

            return ans != int.MaxValue ? ans : -1;
        }

        public int min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }
    }
}