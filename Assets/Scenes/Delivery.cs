using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour {
    [SerializeField] float destroyDelay = 0.5f;
    bool hasRedPackage = false;
    bool hasBluePackage = false;
    bool hasBrownPackage = false;

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collided!");
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "RedPackage") {
            Debug.Log("Picked up RED package.");
            hasRedPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "RedCustomer") {
            if (hasRedPackage == true) {
                Debug.Log("Delivered RED package!");
                hasRedPackage = false;
            }
            else {
                Debug.Log("RED package needs to be picked up first!");
            }
        }

        if (other.tag == "BluePackage") {
            Debug.Log("Picked up BLUE package.");
            hasBluePackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "BlueCustomer") {
            if (hasBluePackage == true) {
                Debug.Log("Delivered BLUE package!");
                hasBluePackage = false;
            }
            else {
                Debug.Log("BLUE package needs to be picked up first!");
            }
        }

        if (other.tag == "BrownPackage") {
            Debug.Log("Picked up BROWN package.");
            hasBrownPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "BrownCustomer") {
            if (hasBrownPackage == true) {
                Debug.Log("Delivered BROWN package!");
                hasBrownPackage = false;
            }
            else {
                Debug.Log("BROWN package needs to be picked up first!");
            }
        }
    }
}
