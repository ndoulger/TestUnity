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
                        SceneManager.LoadScene("PlantInfoScene2");
                        break;
                    case "btnPrevius":
                          SceneManager.LoadScene("PlantInfoScene");
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
