namespace MyPlayground
{
    class Person
    {
        //field
        private string _name;
        private int _age;
        public string nickname;
        public readonly string nationality;
        public static int TotalPeople = 0;
        /*
         * 
         */

        // public properties 
        public string Name
        {
            get { return _name; }
            set
            {
                if (value is string)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid value for Name. Expected type: string.");
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            { if (value is int)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid value for age. Expected type : int");
                }
            }
        }

        //constructor
    

        public Person() : this("No Name", 0, "No Nickname", "Default") { TotalPeople ++; }
        public Person(string name) : this(name,0,"", "Default") { TotalPeople++; }
        public Person(string name, int age) : this(name, age, "", "Default") { TotalPeople++; }

        public Person(string name, int age, string nickname, string nationality ="Default")
        {
            _name = name;
            _age = age;
            this.nickname = nickname;
            this.nationality = nationality;
            TotalPeople++;
        }

        //because this is read only we cannot assign new val to nationality
        //public string Say(string newVal)
        //{
        //     this.nationality = newVal;
        //}

    }

}