using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Rigidbody _rB;

    // Start is called before the first frame update
    void Start()
    {
        _rB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.DrawRay(transform.position, Vector3.down *3f, Color.blue);
        RaycastHit hitInfo;
        if(Physics.Raycast(transform.position, Vector3.down, out hitInfo , 3f))
        {
            if(hitInfo.collider.name == "Floor")
            _rB.isKinematic = true;
            _rB.useGravity = false;
        }
    }

    /*private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        //Gizmos.DrawLine(transform.position, Vector3.down * 2f);
        Debug.DrawLine(transform.position, Vector3.down * 1f);
    }*/
}
