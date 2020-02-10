using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise2
{
    class Movie : IWritable
    {
        private string name;
        private string screenWriter;

        public Movie(string name, string screenWriter)
        {
            this.name = name;
            this.screenWriter = screenWriter;
        }

        public string GetNameOfWork()
        {
            return name;
        }

        public string GetWriter()
        {
            return screenWriter;
        }
    }
}
