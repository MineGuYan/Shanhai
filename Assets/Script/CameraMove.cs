using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    public float MinX, MinY, MaxX, MaxY;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 p= transform.position;
        p.x = player.position.x;
        p.y = player.position.y;
        if(p.x>MaxX) p.x = MaxX;
        else if(p.x<MinX) p.x = MinX;
        if(p.y>MaxY) p.y = MaxY;
        else if(p.y<MinY) p.y = MinY;
        transform.position = p;
    }
}
