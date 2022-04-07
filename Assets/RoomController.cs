using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    public GameObject[] portals;

    public void Start()
    {
        foreach (GameObject portal in portals)
        {
            portal.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            foreach(GameObject portal in portals)
            {
                portal.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject portal in portals)
            {
                portal.SetActive(false);
            }
        }
    }

    

}
