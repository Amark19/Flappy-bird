using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Displayscore : MonoBehaviour
{
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score=0;
    }

    void Update(){
        GetComponent<Text>().text=score.ToString();
    }
}
