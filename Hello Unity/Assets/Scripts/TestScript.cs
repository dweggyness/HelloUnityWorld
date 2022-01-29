using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
  public Rigidbody rb;
  public float speed = 10.0f;
  
  MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
      if (rb == null) {
        rb = GetComponent<Rigidbody>();
      }

      meshRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 randDir = Random.onUnitSphere * speed;

      rb.AddForce(new Vector3(randDir.x, 0, randDir.z));
    }

    private void OnCollisionEnter(Collision collision) {
      
      if (collision.gameObject.tag == "Obstacle") {
        MeshRenderer otherObj = collision.gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material.color = otherObj.material.color;
      }
    }
}
