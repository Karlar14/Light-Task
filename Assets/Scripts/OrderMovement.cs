using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderMovement : MonoBehaviour{
    float spawnTime;
    public GameObject Customer;
    public Vector3 startPos;
    public Vector3 speed;
    // when it gets to a certain point thje G.o stops 
    public Vector3 cutOff;
    public float maxTime;
    public float minTime;
    // Start is called before the first frame updat
    void Start()
    {
        GetComponent<Transform>().position = startPos;
    }

    // Update is called once per frame
    void Update()
    {   // if it reachs a certain x it will go somewhere
        if (GetComponent<Transform>().position.x < cutOff.x) {
            // yield return new WaitForSeconds(spawnTime);
            transform.position += speed;
        }
        else {
            GetComponent<Transform>().position = startPos;
            OrderBehavior.orderComplete = false;
        }
    }
    // spawn randomlys 
    void RandomTime() {
        spawnTime = Random.Range (minTime, maxTime);
    }

}
