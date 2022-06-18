using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareketi : MonoBehaviour
{
    public float karakterHizi;
    public Rigidbody2D rb;
    Vector2 hareket;
    private bool karakterSa�Y�z = true;
    public GameObject restartButton;

    // Update is called once per frame
    void Update()
    {
        if(!ScoreGenerator.win)
        {
            hareket.x = Input.GetAxis("Horizontal");
            hareket.y = Input.GetAxis("Vertical");
            
        }
        else 
        {
            restartButton.SetActive(true);
        }
        

    }

    private void FixedUpdate ()
    {
        if (!ScoreGenerator.win)
        {
            rb.MovePosition(rb.position + hareket * karakterHizi * Time.deltaTime);

            if (karakterSa�Y�z == false && hareket.x > 0)
            {
                Flip();

            }
            else if (karakterSa�Y�z == true && hareket.x < 0)
            {
                Flip();
            }
        }
        
    }

    private void Flip()
    {
        karakterSa�Y�z = !karakterSa�Y�z;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

   

}
