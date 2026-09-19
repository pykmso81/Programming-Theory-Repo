using UnityEngine;

public class Dog : Animal
{
    void Start()
    {
        Eat();   
    }

    public override void Eat()
    {
        Debug.Log("Dog is eating");
    }

}