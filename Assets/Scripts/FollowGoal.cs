using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowGoal : MonoBehaviour
{
    [SerializeField] private GameObject _goal;

    private NavMeshAgent NMATank;

    // Start is called before the first frame update
    void Start()
    {
        NMATank = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        NMATank.destination = _goal.transform.position;
    }
}
