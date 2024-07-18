using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] WayPoint;
    public GameObject Main;
    public MainCar Carscript;

    public NpcScript[] Npc;
    public GameObject[] Npcs;

    int order = 1;

    public Transform[] WayPoints;

    public TextMeshProUGUI Counter;
    int waypoint;
    int lap;
    void Start()
    {
        InvokeRepeating("Count", 0, 1);
        Carscript = Main.GetComponent<MainCar>();

        for (int i = 0; i < 8; i++)
        {
            Npc[i] = Npcs[i].GetComponent<NpcScript>();
        }
    }


    void Count()
    {
        lap = Carscript.tour;
        waypoint = Carscript.waypoint;

        for (int i = 0; i < 8; i++)
        {

            if (Npc[i].Tour > lap)
            {
                order++;
            }
            else if (Npc[i].Tour == lap && Npc[i].number > waypoint)
            {
                order++;
            }
            else if (Vector3.Distance(Npcs[i].transform.position, WayPoints[waypoint].position) < Vector3.Distance(Main.transform.position, WayPoints[waypoint].position))
            {
                order++;
            }
            

        }
        Counter.text="S�ralama:"+order.ToString();
        order = 1;
    }
}