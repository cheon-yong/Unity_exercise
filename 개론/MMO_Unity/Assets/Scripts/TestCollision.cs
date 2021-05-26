using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) 나한테 RigidBody가 존재 (IsKinematic : off)
    // 2) 나한테 Collider가 존재 (IsTrigger : off)
    // 3) 상대한테 Collider가 존재 (IsTrigger : off)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collsion!");
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triiger !");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
