using UnityEngine;

public class Player : Charakter
{
    [SerializeField] private Weapon selectedWeapon;

    public override void Attack(Charakter toHit)
    {
        float damage = selectedWeapon.GetDamage();
        toHit.GetHit(damage);
        Debug.Log("Im atacking");
    }

    

    public void Heal()
    {
        health += 2;
    }
}
