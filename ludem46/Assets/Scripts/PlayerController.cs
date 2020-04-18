using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float movementSpeed = 1f;

    public PlayerState playerState = PlayerState.Idle;

    private bool CarryingPlant = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerState != PlayerState.Dead)
        {
            transform.Translate(movementSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, movementSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);
            if (Input.GetButtonDown("Fire1"))
            {
                if(CanAction())
                {
                    Debug.Log("Attack");
                }
            }
            if(Input.GetButtonDown("Fire2"))
            {
                if (CanAction())
                {
                    if(CarryingPlant)
                    {
                        Debug.Log("Put down the plant");
                    }
                    else
                    {
                        Debug.Log("Pick up the plant");
                    }
                    CarryingPlant = !CarryingPlant;
                }
            }
        }

    }

    bool CanAction()
    {
        return playerState == PlayerState.Idle || playerState == PlayerState.Walking;
    }
}

public enum PlayerState
{
    Idle,
    Walking,
    Attacking,
    Dead
}