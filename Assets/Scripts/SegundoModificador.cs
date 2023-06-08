using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoModificador : MonoBehaviour
{
    [SerializeField] BallController ballController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ballController.materialController.ChangeEmissionColor(MaterialChange.OnOnlyVertical);
            ballController.myRGBD.velocity = new Vector3(ballController.myRGBD.velocity.x, 0, ballController.myRGBD.velocity.z);
            Destroy(gameObject);
        }
    }
}
