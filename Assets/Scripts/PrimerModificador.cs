using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerModificador : MonoBehaviour
{
    [SerializeField] BallController ballController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ballController.myRGBD.velocity = new Vector3(0, ballController.myRGBD.velocity.y, ballController.myRGBD.velocity.z);
            Destroy(gameObject);
        }
    }


}
