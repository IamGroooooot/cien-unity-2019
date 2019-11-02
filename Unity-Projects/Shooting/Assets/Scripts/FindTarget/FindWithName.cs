using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindWithName : MonoBehaviour
{
    private GameObject myTarget;

    // Start is called before the first frame update
    void Start()
    {
        myTarget = GameObject.Find("MyTarget");
        
        if(myTarget != null)
        {
            Debug.Log("GameObject("+myTarget.name+")을 "+"찾았습니다");
        }
        else
        {
            Debug.Log("해당하는 게임 오브젝트를 찾지 못했습니다");
        }
    }

    // Update is called once per frame
    void Update()
    {
        myTarget.GetComponent<Rigidbody>().AddForce(2,0,0);
    }
}


