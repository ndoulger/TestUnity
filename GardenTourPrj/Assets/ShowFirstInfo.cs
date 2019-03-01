using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFirstInfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Info1").SetActive(true);
        GameObject.Find("Info2").SetActive(false);

        GameObject.Find("btnNext").SetActive(true);
        GameObject.Find("btnPrevius").SetActive(false);

        GameObject.Find("btnSound").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
