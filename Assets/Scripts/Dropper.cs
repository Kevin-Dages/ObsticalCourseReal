using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer visable;
    Rigidbody gravityOff;
   [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        visable = GetComponent<MeshRenderer>();

        visable.enabled = false;

        gravityOff = GetComponent<Rigidbody>();

        gravityOff.useGravity = false;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > timeToWait)
        {
            gravityOff.useGravity = true;
            visable.enabled = true;
           
        }
      /// Debug.Log(Time.time); 
    }
}
