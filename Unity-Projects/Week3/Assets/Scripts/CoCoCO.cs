using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoCoCO : MonoBehaviour
{
    string myValue;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetString("이름","고주형");
        myValue = PlayerPrefs.GetString("이름");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myValue);

    }

    public IEnumerator DebugMeIn3Sec(float delay,float speed)
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(delay);
            Debug.Log(delay + "초 후 호출 됨 1");
            yield return new WaitForSecondsRealtime(delay);
            Debug.Log(delay + "초 후 호출 됨 2");
            yield return new WaitForSecondsRealtime(delay);
            Debug.Log(delay + "초 후 호출 됨 ");

        }
    }
}
