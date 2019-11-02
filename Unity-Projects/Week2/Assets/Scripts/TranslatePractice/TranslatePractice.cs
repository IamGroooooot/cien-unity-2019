using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslatePractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //상대 좌표
        //transform.Translate(Time.deltaTime,0,0);

        //월드 좌표
        transform.Translate(Time.deltaTime, 0, 0,Space.World);

    }
}
