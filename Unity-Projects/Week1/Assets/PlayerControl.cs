using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1f;


        if (Input.GetKey(KeyCode.W)) {
            target.transform.Translate(0, 0, speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            target.transform.Translate(0, 0, -speed*Time.deltaTime);
        
        }

        if (Input.GetKey(KeyCode.A))
        {
            target.transform.Translate(-speed*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            target.transform.Translate(speed*Time.deltaTime, 0, 0);
        }



    }
}
