using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlantSeedScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Daisy").SetActive(false);
        GameObject.Find("ortansia").SetActive(false);
        GameObject.Find("SnowDrop").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
