using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antiRoll : MonoBehaviour
{
    public WheelCollider wheelL;
    public WheelCollider wheelR;
    public Rigidbody rb;
    public float antiRollForce = 5000.0f;

    void FixedUpdate()
    {
        WheelHit hit;
        float travelL = 1.0f;
        float travelR = 1.0f;

        bool groundedL = wheelL.GetGroundHit(out hit);
        if (groundedL)
            travelL = (-wheelL.transform.InverseTransformPoint(hit.point).y - wheelL.radius) / wheelL.suspensionDistance;

        bool groundedR = wheelR.GetGroundHit(out hit);
        if (groundedR)
            travelR = (-wheelR.transform.InverseTransformPoint(hit.point).y - wheelR.radius) / wheelR.suspensionDistance;

        float antiRollForceValue = (travelL - travelR) * antiRollForce;

        if (groundedL)
            rb.AddForceAtPosition(wheelL.transform.up * -antiRollForceValue, wheelL.transform.position);
        if (groundedR)
            rb.AddForceAtPosition(wheelR.transform.up * antiRollForceValue, wheelR.transform.position);
    }
}
