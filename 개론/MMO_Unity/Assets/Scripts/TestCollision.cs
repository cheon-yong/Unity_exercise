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
        Debug.Log($"Collsion! @ {collision.gameObject.name}");
    }

    // 1) 둘 다 Collider 가 있어야 한다
    // 2) 둘 중 하나는 IsTrigger : On
    // 3) 둘 중 하나는 Rigidbody가 있어야 한다
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Triiger ! @ {other.gameObject.name}");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
