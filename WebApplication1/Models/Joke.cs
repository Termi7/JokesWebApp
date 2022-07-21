using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }

        public string JokesQuestionn { get; set; }
        public string JokesAnswer { get; set; }

        public Joke()
        {

        }
    }
}
