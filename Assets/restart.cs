using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public void RestartGame()
    {
        ScoreGenerator.win = false;
        this.transform.parent.gameObject.SetActive(false);
        ScoreGenerator.yildizpuani_int = 0;
        Scene scene;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
        
        print(ScoreGenerator.win);

    }
}
