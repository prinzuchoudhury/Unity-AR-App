using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paly : MonoBehaviour
{
    // Start is called before the first frame update9g9de
    public Vector3 temp;
    
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();

        }

    }

}