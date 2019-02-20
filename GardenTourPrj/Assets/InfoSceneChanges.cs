using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoSceneChanges : MonoBehaviour
{
    string btnName;
   // int InfoNum;
    // Start is called before the first frame update
    void Start()
    {
    
        GameObject.Find("Info1").SetActive(true);
        GameObject.Find("Info2").SetActive(false);
      
        GameObject.Find("btnNext").SetActive(true);
        GameObject.Find("btnPrevius").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                if (btnName == "btnClose")
                {
                    SceneManager.LoadScene("AugmentedMenuScene");
                }
            }


            }
         
        }
    }

