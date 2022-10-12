using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKevin : MonoBehaviour
{
 [SerializeField]float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Instructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement(); 
    }

    void Instructions()
    {
        Debug.Log("Welcome to the game \n 1.Move your player with WASD or Arrow Keys");
        Debug.Log("Dont hit the walls");
        
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}
