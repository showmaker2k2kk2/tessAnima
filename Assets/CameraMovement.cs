using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
public Vector3 ofset;
    public float smooth;

    void Start()
    {
        ofset= transform.position-player.position;
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 newpos= player.position+ofset;
        transform.position = Vector3.Lerp(transform.position, newpos, smooth);

    }
}
