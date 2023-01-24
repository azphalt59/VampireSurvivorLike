using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu][System.Serializable]
public class ProjectileAttack : ScriptableObject
{
    public GameObject projectilePrefab;
    public float projectileSpeed;

    public void Shot(Transform target, Quaternion quaternion)
    {
        GameObject projectile = Instantiate(projectilePrefab, target.position, quaternion);
        projectile.GetComponent<Projectile>().projSpeed = projectileSpeed;
    }
}
