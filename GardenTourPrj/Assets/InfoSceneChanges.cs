using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoSceneChanges : MonoBehaviour
{
    string btnName;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Info1").SetActive(true);
       // GameObject.Find("Info2").SetActive(false);
      //  GameObject.Find("Info3").SetActive(false);
       // GameObject.Find("btnNext").SetActive(true);
      //  GameObject.Find("btnPrevius").SetActive(true);
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

                switch (btnName)
                {
                    case "btnClose":
                        SceneManager.LoadScene("AugmentedMenuScene");
                        break;
                    case "btnNext":
                    //    GameObject.Find("Info2").SetActive(true);
                        GameObject.Find("Info1").SetActive(false);
                      //  GameObject.Find("Info2").SetActive(true);
                       // GameObject.Find("btnPrevius").SetActive(true);

                        //SceneManager.LoadScene("PlantInfoScene2");
                        break;
                    case "btnPrevius":
                   //     GameObject.Find("Info1").SetActive(true);
                     //   GameObject.Find("Info2").SetActive(false);
                     //   GameObject.Find("btnPrevius").SetActive(false);
                        //SceneManager.LoadScene("PlantInfoScene");
                        break;
                    case "btnNext2":
                        SceneManager.LoadScene("PlantInfoScene3");
                        break;
                    case "btnPrevius2":
                        SceneManager.LoadScene("PlantInfoScene2");
                        break;
                    default:
                        break;
                }
              
            }
         
        }
    }
}
