namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            //creates a list of programmers (a team)
            Team team1 = new Team();

            //User manualy adds programmers to the team
            Programmer PeterProgrammer = new Programmer("Peter", Specialty.Csharp);
            Programmer KevinProgrammer = new Programmer("Kevin", Specialty.Java);
            Programmer JohnProgrammer = new Programmer("John", Specialty.Csharp);
            Programmer SusanProgrammer = new Programmer("Susan", Specialty.Java);
            Programmer EmmaProgrammer = new Programmer("Emma");
            team1.AddProgrammer(PeterProgrammer);
            team1.AddProgrammer(KevinProgrammer);
            team1.AddProgrammer(JohnProgrammer);
            team1.AddProgrammer(SusanProgrammer);
            team1.AddProgrammer(EmmaProgrammer);

            //Prints the team
            team1.PrintAllTeamMembers();
        }
    }
}
