using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Domain
{
    public class StudentStream : IEnumerable<StudentGroup>
    {
        public int StreamNumber { get; private set; }
        public List<StudentGroup> Groups { get; private set; }

        public StudentStream(int streamNumber)
        {
            StreamNumber = streamNumber;
            Groups = new List<StudentGroup>();
        }

        public void AddGroup(StudentGroup group)
        {
            Groups.Add(group);
        }

        public override string ToString()
        {
            return $"StudentStream [StreamNumber={StreamNumber}, Groups={Groups}]";
        }

        public IEnumerator<StudentGroup> GetEnumerator()
        {
            return Groups.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
