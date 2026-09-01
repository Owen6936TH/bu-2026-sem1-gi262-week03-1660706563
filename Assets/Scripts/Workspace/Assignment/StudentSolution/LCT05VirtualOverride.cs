using UnityEngine;


namespace Assignment.StudentSolution.LCT05
{
    public class Animal
    {
        // 0. make MakeSound method to virtual method
        public virtual void MakeSound()
        {
            Debug.Log("Generic animal sound");
        }
    }

    public class Dog : Animal
    {
        // 1. declare overridden MakeSound() method
        public override void MakeSound()
        {
            Debug.Log("Woof!");
        }
    }

    public class Cat : Animal
    {
        // 2. declare overridden MakeSound() method
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
    }



    public class LCT05VirtualOverride
    {
        public void Start()
        {
            // 3. create instance of Dog and call MakeSound()
            Animal dog = new Dog();
            dog.MakeSound();

            // 4. create instance of Cat and call MakeSound()
            Animal cat = new Cat();
            cat.MakeSound();

            // 5. create instance of Animal and call MakeSound()
            Animal animal = new Animal();
            animal.MakeSound();
        }
    }
}
