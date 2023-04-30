using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class TriggerGameOver : MonoBehaviour
{
    public Collider bola;
    public GameObject GameOverCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            GameOverCanvas.SetActive(true);
        }
    }
}