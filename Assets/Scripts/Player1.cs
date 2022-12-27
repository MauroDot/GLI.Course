using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : MonoBehaviour
{
    //Make a Variable for a prefab to instantiate
    [SerializeField]
    private GameObject _spherePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if left click
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            // or: Ray rayOrigin = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            //raycast (origin = mouse pos)
            //hitInfo (to detect the floor)
            //instantiate sphere at the hit point
            
            Debug.Log("Left CLicked");

            Vector2 mousPos = Mouse.current.position.ReadValue();
            Ray rayOrigin = Camera.main.ScreenPointToRay(mousPos);
            
            RaycastHit hitInfo;

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                Debug.Log("Hit: " + hitInfo.collider.name);
                Instantiate(_spherePrefab, hitInfo.point, Quaternion.identity);
            }
        }
       
    }
}
