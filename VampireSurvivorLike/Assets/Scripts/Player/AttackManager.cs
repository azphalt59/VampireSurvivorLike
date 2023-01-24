using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public List<AttackUpgrade> attackMoves;
    public Transform target;

    private void Start()
    {
        target = EnemiesManager.Instance.Player.gameObject.transform;
    }

    private void Update()
    {
        foreach (AttackUpgrade attack in attackMoves)
        {
            if(attack!= null)
            {
                attack.attackTimer += Time.deltaTime;
                if (attack.attackTimer > attack.attackCooldown)
                {
                    attack.attackTimer = 0f;
                    attack.Attack(target, Quaternion.identity);
                }
            }
        }
    }
    
}
