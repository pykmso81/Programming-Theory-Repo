using UnityEngine;

public class Cat : Animal //inheretance

{
    void Start()
    {
        Eat();
    }

    // polymorphism
    public override void Eat()
    {
        Debug.Log("cat eating meow meow");
    }
}
