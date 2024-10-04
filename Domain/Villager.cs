using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Villager
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public  string BirthSeason { get; set; }
        public int Birthday { get; set; }
        public string Description { get; set; }
        public bool IsMarriageCandidate { get; set; }
    }
}