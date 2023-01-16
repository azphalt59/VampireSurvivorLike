using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalMvt = Input.GetAxisRaw("Horizontal");
        float verticalMvt = Input.GetAxisRaw("Vertical");
        Vector3 movementVector = new Vector3(horizontalMvt, 0, verticalMvt).normalized;
        movementSpeed = PlayerStats.Instance.GetGeneralStats().movementSpeed * (1 + PlayerStats.Instance.GetGeneralStats().movementSpeedMultiplier);

        GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.position += movementSpeed * Time.deltaTime * movementVector;
    }
}
