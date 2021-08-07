using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipeLeft : MonoBehaviour
{
   public float speed;
   private void Start() {
   }
   private void Update() {
       transform.position+=Vector3.left*speed*Time.deltaTime;
    //    Debug.Log(Time.deltaTime);
   }
}
