using UnityEngine;

public class Toyota : Vehicle

{
    void Start()
    {

        Debug.Log("car speed " + Speed);
        Speed = 150f;
        Debug.Log("car speed " + Speed);
    }

}
