using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAngler : MonoBehaviour
{
    [SerializeField]
    private Vector3 _angleVelocity;
    
    void Update()
    {
        transform.localEulerAngles += _angleVelocity * Time.deltaTime;
    }
}
