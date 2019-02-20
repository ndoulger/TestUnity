using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScrollNextInfo()
    {
        if (GameObject.Find("Info1"))
        {
            GameObject.Find("Info1").SetActive(false);
            GameObject.Find("Info2").SetActive(true);

        }
        else
        {
            GameObject.Find("Info1").SetActive(true);
            GameObject.Find("Info2").SetActive(false);

        }
    }
}
