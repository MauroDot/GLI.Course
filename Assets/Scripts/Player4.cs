using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player4 : MonoBehaviour
{
    // store target destination
    [SerializeField]
    private Vector3 _targetDestination;
    void Start()
    {
        
    }

    void Update()
    {
        //move towards target
        //code logic for movement
        //calculate didstance
        var distance = Vector3.Distance(_targetDestination, transform.position);

        if(distance > 1.0f)
        {
            //direction = destination - source
            var direction = _targetDestination - transform.position;
            direction.Normalize();
            //move toward the destination
            transform.Translate(direction * 2.0f * Time.deltaTime);
        }
    }

    public void UpdateDestination(Vector3 pos)
    {
        pos.y = 0.55f;
        _targetDestination = pos;
    }
}
