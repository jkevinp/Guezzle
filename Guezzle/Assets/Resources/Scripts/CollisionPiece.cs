using UnityEngine;
using System.Collections;

public class CollisionPiece : MonoBehaviour {
    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        Debug.DrawRay(collision.transform.position, this.transform.position, Color.white);
    }
        
}
