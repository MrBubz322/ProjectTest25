using UnityEngine;

public class Enemy : Charakter
{
    [SerializeField] private float minDamage, maxDamage;
    public override void Attack(Charakter toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        toHit.GetHit(damage);
        Debug.Log("I m atacking player: ");
    }

}