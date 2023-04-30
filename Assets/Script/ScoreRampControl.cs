using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRampControl : MonoBehaviour
{
    public Collider bola;
    public ScoreManager scoreManager;
    public float score;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            scoreManager.Addscore(score);
        }
    }
}
