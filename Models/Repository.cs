using System.Collections.Generic;
using System.Linq;

namespace ApplicationFormular.Models
{
    public static class Repository
    {
        private static List<ParticipantDetails> details = new List<ParticipantDetails>();

        public static IEnumerable<ParticipantDetails> Details => details;

        public static void AddResponse (ParticipantDetails detail)
        {

            if (!details.Any(x => x.Email == detail.Email))
            {
                details.Add(detail);
            } 
        }
    }
}
