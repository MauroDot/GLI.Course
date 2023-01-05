using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    //store all waypoints
    //select a random wayoint
    //travel to that random waypoint
    //start is called before the first frame update
    [SerializeField]
    GameObject[] _wayPoints;
    private NavMeshAgent _agent;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var randoTarget = Random.Range(0, _wayPoints.Length);
            _agent.destination = _wayPoints[randoTarget].GetComponent<Transform>().position;
            Debug.Log($"Destination: {randoTarget}");
        }
    }
}
