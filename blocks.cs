using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject block;
    public GameObject fire_ball;

    List<GameObject> my_blocks = new List<GameObject>();

    void Start()
    {
        
    }

    public void make_block()
    {

      GameObject xyz= Instantiate(block, transform.position, Quaternion.identity);
        my_blocks.Add(xyz);


    }

    public void make_fire_block()
    {

        my_blocks.Add(Instantiate(fire_ball, transform.position, Quaternion.identity));

    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void destroy_it()
    {
        Destroy(my_blocks[my_blocks.Count-1]);
        my_blocks.RemoveAt(my_blocks.Count-1); 

    }

}
