using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cracker2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dust_explosion;
    public GameObject butterfly_explosion;
    public Vector3 position= new Vector3(0,0.1f,0);
   
    private bool once = true;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void now_get_exploded()
    {
        if (once)
        {
            GameObject dust_ex = Instantiate(dust_explosion, transform.position, Quaternion.identity);
            Destroy(this.gameObject,0.5f);
            Destroy(dust_ex, 2.00f);
            GameObject be= Instantiate(butterfly_explosion, transform.position, Quaternion.identity);
            Destroy(be, 10.00f);
            once = false;
        }

     
    }
}
