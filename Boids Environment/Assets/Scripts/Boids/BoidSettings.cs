using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public  class BoidSettings : ScriptableObject {
    // Settings
    public float minSpeed = 2;
    public float maxSpeed = 5;
    public float perceptionRadius = 2.5f;
    public float avoidanceRadius = 1;
    public float maxSteerForce = 3;

    public float alignWeight = 1;
    public float cohesionWeight = 1;
    public float seperateWeight = 1;

    public float targetWeight = 1;

    static System.Random random = new System.Random();
    public float hunger = 100 + random.Next(0, 15);
    

    [Header ("Collisions")]
    public LayerMask obstacleMask;
    public LayerMask thisBoid;
    public LayerMask preyMask;
    public float boundsRadius = .27f;
    public float avoidCollisionWeight = 10;
    public float collisionAvoidDst = 5;

  /*  public void setObstacleMask(LayerMask ob)
    {
        obstacleMask = ob;
    }*/

}

