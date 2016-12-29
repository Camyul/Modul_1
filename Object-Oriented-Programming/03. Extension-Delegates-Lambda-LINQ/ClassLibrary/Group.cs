namespace ClassLibrary
{
    public class Group                      //Task 16
    {
        public int GroupNum { get; set; }  
        public string GroupName { get; set; }

        public Group(int number, string name)
        {
            this.GroupNum = number;
            this.GroupName = name;
        }
    }
}
