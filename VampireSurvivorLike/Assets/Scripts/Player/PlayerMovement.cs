using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed;
    // Update is called once per frame
    void Update()
    {
        if(GameState.Instance.gameState == GameState.State.Play)
        {
            Movement();
        }
        
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
