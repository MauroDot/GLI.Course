using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI1 : MonoBehaviour
{
    [SerializeField]
    private List<Transform> _points;
    private NavMeshAgent _agent;
    private int _currentPoint = 0;
    private bool _inReverse;
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
        CalculateAIMOvement();
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
}
