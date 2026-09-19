using UnityEngine;

public class Abstraction : MonoBehaviour
{
    public int health = 100;
    public int axeDamage = 12;
    public int swordDamage = 7;

    void Start()
    {
        // abstraction
        AxeHit();
        SwordHit();
    }

    public void AxeHit()
    {
        health -= axeDamage;
        Debug.Log("Hit with axe -" + axeDamage + " | Health: " + health);
    }

    public void SwordHit()
    {
        health -= swordDamage;
        Debug.Log("Hit with sword -" + swordDamage + " | Health: " + health);
    }
}