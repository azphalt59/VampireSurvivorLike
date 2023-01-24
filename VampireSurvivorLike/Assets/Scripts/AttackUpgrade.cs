using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable] [CreateAssetMenu]
public class AttackUpgrade : ScriptableObject
{
    public int initialDamage;
    public float attackCooldown;
    public ProjectileAttack proj;
    public float attackTimer;
   
    [System.Serializable] public enum AttackType
    {
        Aoe, projectile
    }
    [SerializeField]public AttackType attackType;
    public void Attack(Transform target, Quaternion quaternion)
    {
        if(attackType == AttackType.projectile)
        {
            proj.Shot(target, quaternion);
        }
        if(attackType == AttackType.Aoe)
        {

        }
    }


}
