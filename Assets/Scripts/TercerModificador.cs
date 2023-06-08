using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TercerModificador : MonoBehaviour
{
    [SerializeField] BallController ballController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ballController.materialController.ChangeEmissionColor(MaterialChange.OnLooseGravity);
            ballController.myRGBD.useGravity = false;
            Destroy(gameObject);
        }
    }
}
