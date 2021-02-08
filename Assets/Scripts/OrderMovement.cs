using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderMovement : MonoBehaviour{
    float spawnTime;
    public GameObject Customer;
    public Vector3 startPos;
    public Vector3 speed;
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
    {
        if (GetComponent<Transform>().position.x < cutOff.x) {
            // yield return new WaitForSeconds(spawnTime);
            transform.position += speed;
        }
        else {
            GetComponent<Transform>().position = startPos;
            OrderBehavior.orderComplete = false;
        }
    }

    void RandomTime() {
        spawnTime = Random.Range (minTime, maxTime);
    }

}
