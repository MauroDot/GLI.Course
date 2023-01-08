using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class AI1 : MonoBehaviour
{
    private enum AIState
    {
        Walking,
        Jumping,
        Attack,
        Death
    }

    //store all wayopints
    //select a random waypoint
    //travel to the that random waypoint
    //start is called before the first frame
    [SerializeField]
    private List<Transform> _points;
    private NavMeshAgent _agent;
    private int _currentPoint = 0;
    private bool _inReverse;
    [SerializeField]
    private AIState _currentState;
    private bool _attacking = false;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

        var randoTarget = Random.Range(0, _points.Count);

        if(_agent != null)
        {
            _agent.destination = _points[0].position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if e key is pressed 
        //currentState = AI Behavior
        //stop the AI

        if(Keyboard.current.eKey.wasPressedThisFrame)
        {
            _currentState = AIState.Jumping;
            _agent.isStopped = true;
        }

        switch(_currentState)
        {
            case AIState.Walking:
                Debug.Log("Walking...");
                CalculateAIMOvement();
                break;
            case AIState.Jumping:
                Debug.Log("Jumping...");
                break;
            case AIState.Attack:
                Debug.Log("Attack...");
                if(_attacking == false)
                {
                    StartCoroutine(AttackRoutine());
                    _attacking = true;
                }
                break;
            case AIState.Death:
                Debug.Log("Death...");
                break;
        }
    }

    void CalculateAIMOvement()
    {
        if (_agent.remainingDistance < 0.5f)
        {
           if(_inReverse == true)
            {
                Reverse();
            }
            else
            {
                Forward();
            }
            _agent.SetDestination(_points[_currentPoint].position);

            //perform attack
            _currentState = AIState.Attack;
        }
    }
    void Forward()
    {
            if (_currentPoint == _points.Count - 1) //check to see if at the end
            {
                _inReverse = true;
                _currentPoint--;
            }
            else
            {
                _currentPoint++;
            }
    }
    void Reverse()
    {
        if (_inReverse == true)
        {
            //handle reverse logic
            //check if at the beginning
            if (_currentPoint == 0)
            {
                _inReverse = false;
                _currentPoint++;
            }
            else
            {
                _currentPoint--;
            }
        }
    }

    IEnumerator AttackRoutine()
    {
        _agent.isStopped = true;
        yield return new WaitForSeconds(3.0f);
        _agent.isStopped = false;
        _currentState = AIState.Walking;
        _attacking = false;
    }
}
