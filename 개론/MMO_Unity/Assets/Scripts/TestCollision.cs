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

        // Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition)); // Viewport ������ ǥ��
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            LayerMask mask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");
            //int mask = (1 << 8) | (1 << 9);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                // Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
                Debug.Log($"Raycast Camera @ {hit.collider.gameObject.tag}");
            }
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        //    Vector3 dir = mousePos - Camera.main.transform.position;
        //    dir = dir.normalized;

        //    Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);

        //    RaycastHit hit;
        //    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
        //    {
        //        Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
        //    }
        //}
    }
}
