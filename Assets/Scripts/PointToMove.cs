using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PointToMove : MonoBehaviour
{
    [SerializeField]
    private Player4 _player;
    void Start()
    {
        _player = FindObjectOfType <Player4>();
        if(_player == null)
        {
            Debug.Log("Failed to find Player");
        }
    }


    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hitInfo;

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                if(hitInfo.collider.name == "Floor")
                {
                    //update position to move
                    _player.UpdateDestination(hitInfo.point);
                }
            }
        }
    }
}
