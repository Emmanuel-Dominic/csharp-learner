using System;

namespace Classes.Inheritance
{
    // Base Class
    /// <summary>
    /// Represents an animal with a name and action.
    /// </summary>
    public class Animal
    {
        // Properties can be auto-generated - if there's no backing field, the property can hold the data
        /// <summary>
        /// Gets or sets the animal's name.
        /// </summary>
        public string Name { get; set; }

        private string _action = "Eating...";

        /// <summary>
        /// Initializes a new instance of the Animal class.
        /// </summary>
        /// <param name="name">The animal's name.</param>
        /// <param name="action">The animal's action.</param>
        public Animal(string name, string action) {
            Name = name;
            _action = action;
        }

        // There's a shorthand way of writing these using the => operator to create "expression-bodied" properties
        /// <summary>
        /// Gets or sets the animal's action.
        /// </summary>
        public string Action {
            get => _action;
            set => _action = value;
        }

        // You can omit the get or set if you want to prevent
        /// <summary>
        /// Prints the animal's action to the console.
        /// </summary>
        public void Eat() {
            Console.WriteLine(Action);
        }

        /// <summary>
        /// Returns a string representation of the animal.
        /// </summary>
        /// <returns>A string containing the animal's name and action.</returns>
        public virtual string Description()
        {
            return $"Name: {Name}, Action: {Action}";
        }

        /// <summary>
        /// Returns a string representation of the animal.
        /// </summary>
        /// <returns>A string containing the Animal's name and action.</returns>
        public override string ToString()
        {
            return $"The name of the animal is {Name} and it's {Action}";
        }

        // ToString can be overloaded to give different format versions
        // Notice that this version isn't an override function
        /// <summary>
        /// Returns a string representation of the animal.
        /// </summary>
        /// <returns>A string containing the Animal's name and action.</returns>
        public string ToString(char format)
        {
            if(format == 'B') {
                return $"Animal {Name} is {Action}";
            }
            if (format == 'F') {
                return $"The animal is {Name} is {Action} now!";
            }
            return ToString();
        }
    }

    // Derived Class
    /// <summary>
    /// Represents a dog, inheriting from Animal.
    /// </summary>
    public class Dog : Animal
    {
        private string _sound;

        /// <summary>
        /// Initializes a new instance of the Dog class.
        /// </summary>
        /// <param name="name">The dog's name.</param>
        /// <param name="action">The dog's action.</param>
        /// <param name="sound">The dog's sound.</param>
        public Dog(string name, string action, string sound) : base(name, action) {
            _sound = sound;
        }

        // Use properties to implement access to our internal data, this is called a property with a "backing field"
        /// <summary>
        /// Gets or sets the dog's sound.
        /// </summary>
        public string Sound {
            get {
                return _sound;
            }
            set {
                _sound = value;
            }
        }

        /// <summary>
        /// Prints the dog's sound to the console.
        /// </summary>
        public void Bark() {
            Console.WriteLine(Sound);
        }

        /// <summary>
        /// Returns a string representation of the dog.
        /// </summary>
        /// <returns>A string containing the dog's name, action and sound.</returns>
        public override string Description()
        {
            return $"Name: {Name}, Action: {Action}, Sound: {Sound}";
        }
    }
}
