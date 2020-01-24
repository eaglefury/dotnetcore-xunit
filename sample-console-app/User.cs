namespace sample_console_app
{
    public class User
    {
        private readonly string _name;
        private readonly int _age;
        public User(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string getUserDetails()
        {
            return $"users name is {this._name} and age is {this._age}";
        }
    }
}