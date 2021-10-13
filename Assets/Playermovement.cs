using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Playermovement : MonoBehaviour
{
    [Tooltip("Speed multi for Vert and Horz")]
    public float speed = 10;
  Rigidbody rb;
  void Start() {
      rb = this.GetComponent<Rigidbody>();
  }
  public void MoveHorizontal(float force){
      rb.AddForce(0, 0, force);
  }
  public void MoveVertical(float force){
      rb.AddForce(0, 0, force * speed);
  }
}
