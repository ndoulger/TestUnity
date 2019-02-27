using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open3dPlantScene : MonoBehaviour
{
    public void Open3dPlant()
    {
        SceneManager.LoadScene("3dPlantScene");
    }
}
