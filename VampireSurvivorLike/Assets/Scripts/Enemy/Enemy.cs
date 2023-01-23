using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float xpAmout = 100f;
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerStats>() != null)
        {
            other.gameObject.GetComponent<PlayerStats>().AddExperience(xpAmout);
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        EnemiesManager.Instance.enemies.Add(this.gameObject);
    }
    private void OnDestroy()
    {
        EnemiesManager.Instance.enemies.Remove(this.gameObject);
    }
    private void Update()
    {
        if (GameState.Instance.gameState == GameState.State.Play)
        {
            Movement();
        }
    }
    public void Movement()
    {

    }
}
