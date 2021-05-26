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
        Debug.Log($"Collsion! @ {collision.gameObject.name}");
    }

    // 1) �� �� Collider �� �־�� �Ѵ�
    // 2) �� �� �ϳ��� IsTrigger : On
    // 3) �� �� �ϳ��� Rigidbody�� �־�� �Ѵ�
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
