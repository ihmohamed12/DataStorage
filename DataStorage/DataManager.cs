using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataStorage
{
    internal class DataManager
    {
     public   List<Student> students { get; set; }

        public DataManager()
        {
            students = new List<Student>();
        }

      public string  AddStudent(Student s)
        {
            List<Student> newStudents = (JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(@"D:\zdotnet\New Text Document.txt")));
            newStudents.Add(s);
            string result = JsonConvert.SerializeObject(newStudents);
            File.WriteAllText(@"D:\zdotnet\New Text Document.txt", result);
            return result;
        }
        public void GetStudents()
        {
            students = (JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(@"D:\zdotnet\New Text Document.txt")));
        
 
        }
     

    }
}
