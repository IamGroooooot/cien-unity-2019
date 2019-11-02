using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("자식의 Global Position: " + transform.position);
        Debug.Log("자식의 Local  Position: " + transform.localPosition);
    }
}
