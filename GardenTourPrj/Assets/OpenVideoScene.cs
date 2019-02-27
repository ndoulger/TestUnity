using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenVideoScene : MonoBehaviour
{
    public void OpenVideoSnc()
    {
        SceneManager.LoadScene("VideoScene");
    }
}
