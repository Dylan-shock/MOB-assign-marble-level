using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputmanager : MonoBehaviour
{
    public Playermovement player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.MoveHorizontal(Input.GetAxis("Horizontal"));
        player.MoveVertical(Input.GetAxis("Vertical"));
    }
}
