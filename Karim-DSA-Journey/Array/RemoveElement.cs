namespace Karim_DSA_Journey.Array
{
    public class RemoveElement
    {
        public int Remove(int[] nums, int val)
        {
            // [3,2,2,3]
            int read = 0;
            var storageCount = 0;
            int write = 0;
            for(; read < nums.Length;)
            {
                if(nums[read] == val)
                {
                    read++;
                }
                else
                {
                    nums[write] = nums[read];
                    write++;
                    read++;
                    storageCount++;
                }
            }
            return storageCount;
        }
    }
}