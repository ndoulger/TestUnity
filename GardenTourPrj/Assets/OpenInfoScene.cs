using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenInfoScene : MonoBehaviour
{
    public void OpenInfoSn()
    {
        SceneManager.LoadScene("PlantInfoScene");
    }
}
