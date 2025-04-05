using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject leftWarpNode;
    public GameObject rightWarpNode;

    public GameObject pacman;


    public GameObject ghostNodeLeft;
    public GameObject ghostNodeRight;
    public GameObject ghostNodeStart;
    public GameObject ghostNodeCenter;

    public GameObject loserWindowOne;
    public GameObject loserWindowTwo;


    // Start is called before the first frame update
    void Awake()
    {
    // ghostNodeStart.GetComponent<NodeController>().isGhostStartingNode = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
