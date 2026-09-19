using UnityEngine;

public class Dog : Animal
{
    void Start()
    {
        Eat();   
    }


    //polymorphism
    public override void Eat()
    {
        Debug.Log("Dog is eating");
    }

}