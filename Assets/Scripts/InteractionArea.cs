using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.CompareTag("Collectible")){
        Destroy(other.gameObject);
    }
  }
}
