using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovLeft : MonoBehaviour
{
    public GameObject gn1;
    public GameObject gn2;
    public float speed;
    private void Update() {
      
        if(gn1.transform.position.x<=-82f){
            
        gn1.transform.position=new Vector3(gn2.transform.position.x+108.24f,gn1.transform.position.y,gn1.transform.position.z);
        
        }
        if(gn2.transform.position.x<=-82f){
            Debug.Log(speed);
        gn2.transform.position=new Vector3(gn1.transform.position.x+108.24f,gn2.transform.position.y,gn2.transform.position.z);
        
        }
        
        gn1.transform.position+=Vector3.left*speed*Time.deltaTime;
        gn2.transform.position+=Vector3.left*speed*Time.deltaTime;
    }
}
