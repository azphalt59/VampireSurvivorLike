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
}
