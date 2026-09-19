using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private float speed = 10f;

    
    public float Speed
    {
        get { return speed; }
        set 
        { 
            if (value > 100f)
            {
                speed = 100f;
                Debug.Log("Max speed!");
            }
            else
            {
                speed = value;
            }
        }
    }
}
