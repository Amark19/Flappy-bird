using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    public Gamemanger gamemanager;
   public float velocity=1;
    private Rigidbody2D rb;
    public AudioSource Birdjump;
    public AudioSource GameOver;
    private void Start() {
        rb=GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase==TouchPhase.Began)){
            rb.velocity=Vector2.up*velocity;
            Birdjump.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        gamemanager.GameOver();
        GameOver.Play();
}
}
