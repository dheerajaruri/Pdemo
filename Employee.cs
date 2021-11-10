using System;

namesapace Pdemo
{
    public class Employee
    {
        public int Id{get;set;}
        public string Name{get; set;}
        public double salary{get; set;}

        public overrirde string ToString()
        {
            return $"{ID}\t{Name}\t{salary}";
        }
    }
}