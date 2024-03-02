using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 100f;
    public Image reticleImage;
    public Color reticleDementorColor;

    Color originalReticleColor;
    
    // Start is called before the first frame update
    void Start() {
        originalReticleColor = reticleImage.color;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            GameObject projectile = Instantiate(projectilePrefab, transform.position + transform.forward, transform.rotation) as GameObject;

            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * projectileSpeed, ForceMode.VelocityChange);
            
            projectile.transform.SetParent(GameObject.FindGameObjectWithTag("ProjectileParent").transform);
            
        }
    }
/*
    void FixedUpdate() {
        reticleEffect();
    }

    void reticleEffect() {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity)) {
            if (hit.collider.CompareTag("Dementor")) {
                reticleImage.color = Color.Lerp(reticleImage.color, reticleDementorColor, Time.deltaTime * 2);

                reticleImage.transform.localScale = Vector3.Lerp(reticleImage.transform.localScale,
                    new Vector3(0.7f, 0.7f, 1), Time.deltaTime * 2);
            }
            else {
                reticleImage.color = Color.Lerp(reticleImage.color, originalReticleColor, Time.deltaTime * 2);

                reticleImage.transform.localScale = Vector3.Lerp(reticleImage.transform.localScale,
                    new Vector3(1, 1, 1), Time.deltaTime * 2);
            }
        }
    }
    */
}
