using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonBehaviour : MonoBehaviour
{
    public int scoreToGive = 1;
    public int clickToPop = 5;

    public float scaleIncrease = 0.2f;

    public ScoreManager ManagerScore;


    public void OnMouseDown()
    {
        if(clickToPop > 0)
        {
            //Eliminar un click
            clickToPop -= 1;

            //Incrementar tamaño
            this.transform.localScale += Vector3.one * scaleIncrease;
        }
        if(clickToPop == 0)
        {
            Debug.Log("Ganaste " + scoreToGive);
            ManagerScore.IncreaseScore(scoreToGive);
            Destroy(this.gameObject);
        }
        
    }
}
