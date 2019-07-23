using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpowner : MonoBehaviour
{
    public GameObject[] objs;
    int objNo;
    public float maxPos = -1.8f;
    public float delayTimer = .5f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <=0){

        Vector3 objPos = new Vector3(transform.position.x, Random.Range(-1.8f, -1.8f), transform.position.z);
        objNo = Random.Range (0,1);
        Instantiate(objs[objNo], objPos, transform.rotation);
        timer = delayTimer;
        }
       
    }
}
