using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static AudioSource player;
    void Start()
    {
        player = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
}
