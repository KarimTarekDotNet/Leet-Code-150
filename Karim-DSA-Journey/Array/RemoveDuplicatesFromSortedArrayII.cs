namespace Karim_DSA_Journey.Array
{
    public class RemoveDuplicatesFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums) 
        {
            // [1,1,1,2,2,3]
            int read = 1;
            int write = 1;
            for (; read < nums.Length; read++)
            {
                if(write < 2 || nums[read] != nums[write - 2])
                {
                    nums[write] = nums[read];
                    write++;
                }
            }
            return write;
        }   
    }
}