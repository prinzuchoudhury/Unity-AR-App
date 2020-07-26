using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_blade : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 0.00f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed*Time.deltaTime,0);
    }
    public void increase_speed()
    {  
        if(speed<=1000.00f)
        speed += 50.00f;

    }
    public void decrease_speed()
    {
        if (speed > 0.00f)
        { 
            speed -= 50.00f; 
        }
        else 
        {
            speed = 00.00f;
        }

    }
  
}
