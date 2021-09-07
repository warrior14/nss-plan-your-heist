namespace BankHeist 
{
    public class Member
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }
        // public List<Member> TeamMember {get; set; }

        public Member(string Name, int skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
            // TeamMember = new List<Member>();
        }
    }
}