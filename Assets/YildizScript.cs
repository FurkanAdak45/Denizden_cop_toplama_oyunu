using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YildizScript : MonoBehaviour
{
 



    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "karakter" && !ScoreGenerator.win)
        {
            ScoreGenerator.yildizpuani_int += 1;
            Destroy(this.gameObject);
        }
    }
}
