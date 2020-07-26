using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket_fire : MonoBehaviour
{
    public GameObject rocket_launcher_ps;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void fire_rocket_launcher()
    {
        GameObject r_l = Instantiate(rocket_launcher_ps, transform.position,Quaternion.identity);
        Destroy(r_l,2.00f);
    }

}