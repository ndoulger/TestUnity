using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstVideoScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("btnPause").SetActive(true);
        GameObject.Find("btnPlay").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
