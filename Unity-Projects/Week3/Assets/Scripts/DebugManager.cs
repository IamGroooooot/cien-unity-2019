using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour
{
    public static DebugManager instance;
    public float HP = 100;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        //Debug.Log("나의 체력은: " + HP);
    }

    public void DebugMe()
    {
        Debug.Log("날 불렀나? ");
    }
}
