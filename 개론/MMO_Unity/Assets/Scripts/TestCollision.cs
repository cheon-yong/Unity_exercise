using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) ������ RigidBody�� ���� (IsKinematic : off)
    // 2) ������ Collider�� ���� (IsTrigger : off)
    // 3) ������� Collider�� ���� (IsTrigger : off)
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
