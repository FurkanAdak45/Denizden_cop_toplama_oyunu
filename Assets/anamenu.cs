using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour
{
   

    public void AnaMenu()
    {
        ScoreGenerator.win = false;
        this.transform.parent.gameObject.SetActive(false);
        ScoreGenerator.yildizpuani_int = 0;
        
        SceneManager.LoadScene("menu");
        

        
    }


}
