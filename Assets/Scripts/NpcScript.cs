using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcScript : MonoBehaviour
{


    private NavMeshAgent agent; 
    public Transform[] WayPoint;
    public int number = 0;
    public int Tour=1;

    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
        Invoke("Letgo", 3);
        
    }



    private void Letgo()
    {
        agent.SetDestination(WayPoint[number].position + new Vector3(Random.Range(-7, +7), 0, 0));
        agent.speed = Random.Range(17, 23);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Waypoint")) {

            if (number==7)
            {
                Tour++;
                number=0;
                agent.SetDestination(WayPoint[number].position + new Vector3(Random.Range(-7, +7), 0, 0));
                agent.speed = Random.Range(17, 23);

            }
            else if (number ==0|| number == 1 || number == 5) 
            {
                number++;
                agent.SetDestination(WayPoint[number].position + new Vector3(0, 0, Random.Range(-7, +7)));
                agent.speed=Random.Range(17,23);
            }
            else 
            {
                number++;
                agent.SetDestination(WayPoint[number].position + new Vector3(Random.Range(-7, +7), 0, 0));
                agent.speed = Random.Range(17, 23);

            }
            
        }
    }

}
