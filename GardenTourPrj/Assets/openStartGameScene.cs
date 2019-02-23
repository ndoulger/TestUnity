using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openStartGameScene : MonoBehaviour
{

 
    public void OpenPlantSeedScene()
    {
        SceneManager.LoadScene("PlantSeedScene");
    }
}
