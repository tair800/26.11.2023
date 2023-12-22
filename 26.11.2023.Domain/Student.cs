namespace _26._11._2023.Domain
{
    public class Student
    {
        private int _id;
        public int Id {  get;  }
        public string FullName { get; set; }
        public int Point {  get; set; }
        public void StudentInfo(string fullName, int point)
        {
            
           
          
            FullName = fullName;
            Point = point;
        }
    }
}
