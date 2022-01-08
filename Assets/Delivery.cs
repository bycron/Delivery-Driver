using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour {
    [SerializeField] Color32 hasRedPackageColor = new Color32 (120, 38, 34, 255);
    [SerializeField] Color32 hasBluePackageColor = new Color32(22, 30, 115, 255);
    [SerializeField] Color32 hasBrownPackageColor = new Color32(140, 92, 55, 255);

    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.2f;
    bool hasRedPackage = false;
    bool hasBluePackage = false;
    bool hasBrownPackage = false;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collided!");
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "RedPackage") {
            Debug.Log("Picked up RED package.");
            hasRedPackage = true;
            spriteRenderer.color = hasRedPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "RedCustomer") {
            if (hasRedPackage == true) {
                Debug.Log("Delivered RED package!");
                hasRedPackage = false;
                spriteRenderer.color = noPackageColor;
            }
            else {
                Debug.Log("RED package needs to be picked up first!");
            }
        }

        if (other.tag == "BluePackage") {
            Debug.Log("Picked up BLUE package.");
            hasBluePackage = true;
            spriteRenderer.color = hasBluePackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "BlueCustomer") {
            if (hasBluePackage == true) {
                Debug.Log("Delivered BLUE package!");
                hasBluePackage = false;
                spriteRenderer.color = noPackageColor;
            }
            else {
                Debug.Log("BLUE package needs to be picked up first!");
            }
        }

        if (other.tag == "BrownPackage") {
            Debug.Log("Picked up BROWN package.");
            hasBrownPackage = true;
            spriteRenderer.color = hasBrownPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "BrownCustomer") {
            if (hasBrownPackage == true) {
                Debug.Log("Delivered BROWN package!");
                hasBrownPackage = false;
                spriteRenderer.color = noPackageColor;
            }
            else {
                Debug.Log("BROWN package needs to be picked up first!");
            }
        }
    }
}
