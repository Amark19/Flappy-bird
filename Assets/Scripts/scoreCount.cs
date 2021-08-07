using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCount : MonoBehaviour
{
   public AudioSource score;
    private void OnTriggerEnter2D(Collider2D other) {
     
        Displayscore.score++;
        score.Play();
    }
}
