using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainCar : MonoBehaviour
{
    public int waypoint = 0;
    public int tour=1;
    public GameObject[] WayPoint;
    public TextMeshProUGUI Lap;
    public TextMeshProUGUI finishOrder;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == WayPoint[waypoint])
        {
            if(waypoint == 7) 
            {
                tour++;
                waypoint = 0;
                
                if (tour==2)
                {
                    Lap.text = "Lap:2/3";
                }
                if (tour==3)
                {
                    Lap.text = "Lap:3/3";
                }
                if(tour==4)
                {
                    Invoke("finish", 0.3f);
                    
                }

            }
            else
            {
                waypoint++;
            }
            


        }
    }
    void Update()
    {
        if(waypoint >=1 || tour >1)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                TeleportToLastWaypoint();
            }
        }
        
    }

    void TeleportToLastWaypoint()
    {
        int lastWaypoint = waypoint == 0 ? WayPoint.Length - 1 : waypoint - 1;
        transform.position = WayPoint[lastWaypoint].transform.position;
    }
    void finish()
    {
        GameController.Instance.finish();

    }
 
}
