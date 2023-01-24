using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public static EnemiesManager Instance;
    public List<GameObject> enemies;
    private List<float> enemiesDistance;
    [SerializeField] public GameObject nearestEnemy;
    public GameObject Player;
    private float nearestDistance = float.MaxValue;
    private float timer = 0;
    public float EnemySpeed = 5f;
    public int EnemyDamage = 15;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > 0.5f)
        {
            ChooseTarget();
        }
    }

    private void ChooseTarget()
    {
        if (enemies.Count == 0)
        {
            nearestEnemy = null;
            return;
        }
        
        nearestDistance = float.MaxValue;


        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i] == null)
            {
                enemies.RemoveAt(i);
                return;
            }

            if (Vector3.Distance(transform.position, enemies[i].transform.position) < nearestDistance)
            {
                nearestDistance = Vector3.Distance(Player.transform.position, enemies[i].transform.position);
                nearestEnemy = enemies[i];
            }
        }
        
    }
}
