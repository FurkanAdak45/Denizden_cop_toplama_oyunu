using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGenerator : MonoBehaviour
{
    public Text yildizpuani;
    public static int yildizpuani_int = 0;

    public static bool win;

   


    // Update is called once per frame
     private void Update()
    {
        yildizpuani.text = yildizpuani_int.ToString();
        if (yildizpuani_int == 10)
        {
            win = true;

            
        }
    }
}
