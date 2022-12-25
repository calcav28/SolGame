using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPoint : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject pivotObject;
    public float ballSizeTimer = 10;
    public float ballSpeedTimer = 10;
    public float ballUltTimer = 15;
    public float ballSizeCooldown = 10;
    public float ballSpeedCooldown = 10;
    public float ballUltCooldown = 15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
        ballSizeTimer += Time.deltaTime;
        ballSpeedTimer += Time.deltaTime;
        ballUltTimer += Time.deltaTime;
        //changes rotation
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Q)) {
            rotationSpeed = rotationSpeed * -1.0f;
        }
        //makes balls bigger
        if ((Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.E)) && ballSizeTimer >= 10.0f) {
            ballSizeTimer = 0;
            gameObject.transform.localScale += new Vector3(1.25f, 1.25f, 1f);
            Invoke("resetBallSize", 5.0f);
        }
        //makes balls rotate faster
        if ((Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.R)) && ballSpeedTimer >= 10.0f) {
            ballSpeedTimer = 0;
            rotationSpeed = rotationSpeed * 2.0f;
            Invoke("resetBallSpeed", 5.0f);
        }
        //ultimate ability
        if ((Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.T)) && ballUltTimer >= 15.0f) {
            ballUltTimer = 0;
            rotationSpeed = rotationSpeed * 2.5f;
            gameObject.transform.localPosition *= 1.25f;
            gameObject.transform.localScale += new Vector3(1.25f, 1.25f, 1f);
            Invoke("resetBallUlt", 5.0f);
        }
    }

    public void resetBallSize() {
        gameObject.transform.localScale += new Vector3(-1.25f, -1.25f, -1f);
    }

    public void resetBallSpeed() {
        rotationSpeed = rotationSpeed / 2.0f;
    }

    public void resetBallUlt() {
        gameObject.transform.localPosition /= 1.25f;
        rotationSpeed = rotationSpeed / 2.5f;
        gameObject.transform.localScale += new Vector3(-1.25f, -1.25f, -1f);

    }

}
