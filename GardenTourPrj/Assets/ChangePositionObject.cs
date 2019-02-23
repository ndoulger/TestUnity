using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePositionObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveTo(GameObject aGameObject)
    {
        transform.position = aGameObject.transform.position;
        //  GameObject.Find("PlantA").transform.position.Set(GameObject.Find("SeedA").transform.position);
    }
}
