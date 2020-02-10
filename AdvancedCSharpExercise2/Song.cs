using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpExercise2
{
    class Song : IWritable
    {
        private string name;
        private string songWriter;

        public Song(string name, string songWriter)
        {
            this.name = name;
            this.songWriter = songWriter;
        }

        public string GetNameOfWork()
        {
            return name;
        }

        public string GetWriter()
        {
            return songWriter;
        }
    }
}
