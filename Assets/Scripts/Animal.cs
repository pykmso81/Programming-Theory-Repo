using UnityEngine;

public class Animal : MonoBehaviour
{
    public virtual void Eat()
    {
        Debug.Log("Animal is eating");
    }
}
