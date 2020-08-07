using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class PenguinAcademy : Academy
{
    //Gets/sets current fish speed
    public float FishSpeed { get; private set; }

    //Gets/sets the current acceptable feed radius
    public float FeedRadius { get; private set; }

    //This function is called when the academy first gets initialized
    public override void InitializeAcademy()
    {
        FishSpeed = 0f;
        FeedRadius = 0f;

        //setup code to be called every time fish-speed parameter changes
        //during curriculum learning
        FloatProperties.RegisterCallback("fish_speed", f => { FishSpeed = f; });

        //setup code to be called every time feed-radius parameter changes
        //during curriculum learning
        FloatProperties.RegisterCallback("feed_radius", f => { FeedRadius = f; });

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
