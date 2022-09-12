using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 1620;
    private void Start()
    {
        Debug.Log("Initial Score: " + score);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            score -= 20;
            Debug.Log("Current Score: " + score);
        }

        if (other.gameObject.tag == "End")
        {
            Debug.Log("Congratulations! You reached the end of the level!");
            Debug.Log("Final Score: " + score);
        }


    }
}
