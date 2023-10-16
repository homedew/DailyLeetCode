public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if(rowIndex == 0) return new List<int>{1};

        List<int> rs = new List<int>();
        IList<int> temp = GetRow(rowIndex - 1);
        rs.Add(1);
        for(int i = 1; i < temp.Count; i++) 
        {
            rs.Add(temp[i - 1] + temp[i]);
        }
        rs.Add(1);

        return rs;
    }
}
// 1
// 1 1
// 1 2 1
// 1 3 3 1