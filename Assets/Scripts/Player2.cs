using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _allShapes;
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Ray rayOrigin = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hitInfo;

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                var rand = Random.Range(0, 3);
                var instance = Instantiate(_allShapes[rand], hitInfo.point, Quaternion.identity);
                var objRenderer = instance.GetComponentInChildren<Renderer>();
                objRenderer.material.color = Random.ColorHSV();
            }
        }
    }
}
