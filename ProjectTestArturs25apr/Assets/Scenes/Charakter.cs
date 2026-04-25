using UnityEngine;

public abstract class Charakter : MonoBehaviour
{
    public string charname;
    public float health;
    public abstract void Attack(Charakter toHit);

    public void GetHit(float damage)
    {
        health = health - damage;
        Debug.Log(charname + "got hit by " + damage + "! Health : " + health);
    }
    
}
