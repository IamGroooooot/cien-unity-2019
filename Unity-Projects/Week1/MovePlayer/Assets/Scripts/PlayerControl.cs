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
        // 상
        if (Input.GetKey(KeyCode.W))
        {
            target.transform.Translate(0, 0, 100 * Time.deltaTime);

        }
        // 하
        if (Input.GetKey(KeyCode.S))
        {
            target.transform.Translate(0, 0, -100 * Time.deltaTime);
        }
        // 좌
        if (Input.GetKey(KeyCode.A))
        {
            target.transform.Translate(-100 * Time.deltaTime, 0, 0);
        }
        // 우
        if (Input.GetKey(KeyCode.D))
        {
            target.transform.Translate(100 * Time.deltaTime, 0, 0);
        }
        // 상
        if (Input.GetKey(KeyCode.Q))
        {
            target.transform.Translate(0, 100 * Time.deltaTime, 0);
        }
        // 하
        if (Input.GetKey(KeyCode.E))
        {
            target.transform.Translate(0, -100 * Time.deltaTime, 0);
        }
    }
}
