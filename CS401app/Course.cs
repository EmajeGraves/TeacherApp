using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherApp
{
    class Course
    {
        public static int CourseId { get; set; }

        public static List<int> CourseSelectList = new List<int>();
        public static List<int> AddIdList = new List<int>();
        public static List<int> DeleteIdList = new List<int>();
    }
}
