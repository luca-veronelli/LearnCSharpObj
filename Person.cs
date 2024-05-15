namespace LearnCSharpObj
{
    internal class Person
    {
        /* PERSON 1
        // These variables are are called 'fields', 'members' or also 'properties'.
        private string firstName = String.Empty;
        private string lastName = String.Empty;
        private byte age;
        private char gender;

        // Functions defined inside a class are called 'methods' of the
        // class. The 'private' keyword means thet this is accessible
        // only inside the class.
        // This is the 'constructor' method of this class, you can have more 
        // than one constructor per class.
        public Person()
        {
            Console.WriteLine("Initialized the object.");
        }

        public Person(string firstName, string lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Console.WriteLine("Initialized 'firstName' and 'lastName' properties.");
            Console.WriteLine($"firstName: {firstName}, lastName: {lastName}");
        }

        public Person(string firstName, string lastName, byte age) : this(firstName, lastName)
        {
            this.age = age;
            Console.WriteLine("Initialized 'age' property.");
            Console.WriteLine($"age: {age}");
        }

        // public keyword means they are accessible both
        // from inside and outside the class.
        // Use the keyword 'this' to refer to this class.
        public Person SetFirstName(string firstName)
        {
            if (isValidName(firstName))
            {
                this.firstName = firstName;
            }
            return this;
        }

        public Person SetLastName(string lastName)
        {
            if (isValidName(lastName))
            {
                this.lastName = lastName;
            }
            return this;
        }
        
		public Person SetGender(char gender)
		{
			this.gender = gender;
			return this;
		}

		public Person SetAge(byte age)
		{
			this.age = age;
			return this;
		}

        public string GetFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }

        public string SayHi()
        {
            return $"Hi, I'm {this.firstName} {this.lastName}";
        }
        */

        /* PERSON 2

        private string _firstName;
        private string _lastName;
        private int _age;

        // Check if the name is valid:
        private bool isValidName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }

        // Properties are members of classes that provides
        // a flexible way to act on the value of a private field
        public string FirstName
        {
            get { return _firstName; }
            set 
            { 
                if (!isValidName(value))
                {
                    throw new ArgumentException("The first name must not be empty or null.");
                }

                _firstName = value; 
            }
        }

        public string LastName 
        { 
            get { return _lastName; }
            set
            {
                if (!isValidName(value))
                {
                    throw new ArgumentException("The last name must not be empty or null.");
                }

                _lastName = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age must be greater than or equal to 0.");
                }

                _age = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        */

        /* PERSON 3
         
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public sbyte Age { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        */

        /* PERSON 4
         
        public string Name { get; init; } = string.Empty;
        public sbyte Age { get; init; } = 1;

        */
    }
}
