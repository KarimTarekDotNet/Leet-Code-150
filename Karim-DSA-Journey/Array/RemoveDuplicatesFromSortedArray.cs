namespace Karim_DSA_Journey.Array
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums) 
        {
            // [0,0,1,1,1,2,2,3,3,4]
            int read = 1;
            int write = 1;
            for (; read < nums.Length; read++)
            {
                if(nums[read] != nums[read - 1])
                {
                    nums[write] = nums[read];
                    write++;
                }
            }
            return write;
        }
    }
}