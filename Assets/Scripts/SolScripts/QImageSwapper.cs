using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QImageSwapper : MonoBehaviour
{

    public GameObject mainImage;
    public GameObject otherImage;
    public KeyCode firstKey;
    public KeyCode secondKey;

    void Update()
    {
        if ((Input.GetKeyDown(firstKey) || Input.GetKeyDown(secondKey)) && mainImage.activeSelf)
        {
            mainImage.SetActive(false);
            otherImage.SetActive(true);
        }
    }
}
