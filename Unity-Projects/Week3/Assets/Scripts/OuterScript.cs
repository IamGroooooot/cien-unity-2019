using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("Manager").GetComponent<DebugManager>().HP -= 1;
        DebugManager.instance.HP -= 1;
    }
}
