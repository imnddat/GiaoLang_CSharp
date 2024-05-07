using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Entities
{
    internal class Student
    {
        public string Id { get; set; } // _backing field sẽ tự động tạo ra khi compile/Run
        public string Name { get; set; } //_name, _email, _yob, _gpa
        public string Email { get; set; } // Prop sẽ che giùm qua 2 hàm Get() Set()
        public int Yob { get; set; }
        public double Gpa { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Email} {Yob} {Gpa}";
        }
    }
}
