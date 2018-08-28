using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class ActorMovie
    {
        public int ID { get; set; }
        public int ActorId { get; set; }
        public string Character { get; set; }
        public int MovieId { get; set; }
    }
}
