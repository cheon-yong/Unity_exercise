using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) �� �Ǵ� ��� RigidBody�� ���� (IsKinematic : off)
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
        /*
        Vector3 look = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position + Vector3.up, look * 10, Color.red);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position + Vector3.up, look, 10);

        foreach (RaycastHit hit in hits)
        {
            Debug.Log($"Ray Cast {hit.collider.gameObject.name}");

        }
        */

        // Local <-> World <-> Viewport <-> Screen
        
        // Debug.Log(Input.mousePosition); // Screen

        Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition)); // Viewport ������ ǥ��
    }
}
