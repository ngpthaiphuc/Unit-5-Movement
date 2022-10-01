using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSpin : MonoBehaviour
{
    [SerializeField] Rigidbody washingMachine;
    [SerializeField] Rigidbody ballerina;
    [SerializeField] Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        washingMachine.AddTorque(moveDirection, ForceMode.Impulse);
        ballerina.angularVelocity = washingMachine.angularVelocity;
    }
}
