using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletholePrefab, _sparkPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //cast raycast through the center of the reticule
        //instantiate a bullet hole prefab
        //if left click
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                Instantiate(_bulletholePrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                Instantiate(_sparkPrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
            }
        }
    }
}
