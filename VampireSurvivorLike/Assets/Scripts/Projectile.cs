using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projSpeed;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = EnemiesManager.Instance.nearestEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * projSpeed);
        transform.LookAt(target.transform);
    }
}
