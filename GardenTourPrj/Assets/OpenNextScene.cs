using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenNextScene : MonoBehaviour
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
                 case "btnInfo":
                    SceneManager.LoadScene("PlantInfoScene");
                    break;
                case "btn3dPlant":
                    SceneManager.LoadScene("3dPlantScene");
                    break;
                // case "myButton3":
                //     myAudioSource.clip = aClips[2];
                //     myAudioSource.Play();
                //     break;
                //  case "myButton4":
                //    myAudioSource.clip = aClips[3];
                //  myAudioSource.Play();
                //break;
                // case "CloseBtn":
                //       Application.wantsToQuit();
                //       break;

                   default:
                      break;
                }
               // if (btnName == "btnInfo")
              //  {
                //    SceneManager.LoadScene("PlantInfoScene");
               // }

            }
        }
    }
}
