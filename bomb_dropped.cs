using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_dropped : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bomb;
    public GameObject explosion_object;
    public float time_ef = 2.00f;
    bool only_once_d = true;
    bool only_once_e = true;
    GameObject bomb_position;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void drop_the_bomb() 
    {
        if (only_once_d)
        {
            bomb_position = Instantiate(bomb, transform.position, Quaternion.identity);
            only_once_d = false;
          
        }

    }


   
     public void Explode_it()
    {
        if (only_once_e)
        {
            Destroy(bomb_position,0.2f);
            Transform b = bomb_position.GetComponent<Transform>();
            GameObject ef = Instantiate(explosion_object, b.position, b.rotation);
            Destroy(ef, time_ef);
            only_once_e = false;
        }
    }
}
