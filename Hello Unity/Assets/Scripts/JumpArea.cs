using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArea : MonoBehaviour
{
  private void OnTriggerEnter(Collider other) {
    Debug.Log("HELLO!");
    if (other.gameObject.tag == "Player") {
      Debug.Log("Cage triggered");
      Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

      rb.AddForce(new Vector3(0, 500, 0));

      Destroy(this.gameObject);
    }
  }
}
