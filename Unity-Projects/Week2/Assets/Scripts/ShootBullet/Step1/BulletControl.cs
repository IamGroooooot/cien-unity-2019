using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,2f); //와 동일
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
