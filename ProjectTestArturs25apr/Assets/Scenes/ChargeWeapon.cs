using UnityEngine;

public class ChargeWeapon : MonoBehaviour
{
    [SerializeField] internal float chargeIncrement = 0.5f;
    private float charge = 0;
    public virtual float GetDamage()
    {
        float damage = baseDamage + charge;
        charge += chargeIncrement;
        return damage;
    }
}