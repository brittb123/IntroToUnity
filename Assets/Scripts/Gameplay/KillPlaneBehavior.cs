using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaneBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PipePairBehavior PipeScript = other.GetComponent<PipePairBehavior>();

        if (PipeScript)
            PipeScript.Destroy();
    }
}
