using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshSurface surface;
    
    public Camera cam;

    public NavMeshAgent agent;

    public Transform Planet;

    Rigidbody r;


    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        surface.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
        surface.BuildNavMesh();

        transform.LookAt(Planet.position);
        transform.Rotate(90, 0, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
