using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Client
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public DateTime EnrollDate { get; set; }
        public DateTime LastActiveDate { get; set; }
        public float CPGA { get; set; }
        public byte[] StudentImage { get; set; }
        public decimal MonthlyTutionFee { get; set; }
        public TimeSpan LastPresentTime { get; set; }
    }
}
