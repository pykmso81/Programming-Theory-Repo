using UnityEngine;

public class Cat : Animal
{
    void Start()
    {
        Eat();
    }

    public override void Eat()
    {
        Debug.Log("cat eating meow meow");
    }
}
