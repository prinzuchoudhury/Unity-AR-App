using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{

    public GameObject Explosion_effect;


    public float explosion_time = 2.00f;
    public float radius = 10.00f;
    public float force = 1000.00f;
    public GameObject remove_walls;
    public float time_for_dust = 2.00f;

    Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        temp = remove_walls.transform.localScale;
        temp = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Explode()
    {
        remove_walls.transform.localScale = temp;
        Destroy(this.gameObject,0.5f);


        GameObject ef = Instantiate(Explosion_effect, transform.position, Quaternion.identity);
        Destroy(ef, explosion_time);

        
        Collider[] nearby_colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObjects in nearby_colliders)

        {
            Rigidbody rb = nearbyObjects.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
        }

    }

}
