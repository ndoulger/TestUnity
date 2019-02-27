using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnMainHandler : MonoBehaviour{
    
	public void BtnMainClick(string scenename)
    {

        SceneManager.LoadScene(scenename);     

    }
}
