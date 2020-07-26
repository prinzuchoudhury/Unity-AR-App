using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_controller : MonoBehaviour
{
    // Start is called before the first frame update

    bool car_move = false;
    public float speed = 50.00f;

    Vector3 temp;

    void Start()
    {

        temp = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (car_move)
        {
            temp.z += speed * Time.deltaTime;
            transform.position = temp;
        }
    }

    public void start_the_game()
    {
        if (car_move)
        {
            car_move = false;
        }
        else
        {
            car_move = true;
        }
    }
}
