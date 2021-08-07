using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapToPlay : MonoBehaviour
{
    public AudioSource ButtonClick;
    // Start is called before the first frame update
    public void Play(){
        ButtonClick.Play();
        SceneManager.LoadScene(1);
    }
}
