using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxtime=2f;
    public float timer=0;
    public GameObject pipe;
    public float height;
 private void Start() {
     GameObject Pipe=Instantiate(pipe);
    Pipe.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
 }
    // Update is called once per frame
    void Update()
    {
        if(timer>maxtime){
            GameObject Pipe=Instantiate(pipe);
            Pipe.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
            timer=0;
            Destroy(Pipe,5);
        }
        timer+=Time.deltaTime;
    }
}
