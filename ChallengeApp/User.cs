namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();
        private User(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

    }
}
