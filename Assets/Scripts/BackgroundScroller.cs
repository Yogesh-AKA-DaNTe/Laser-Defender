using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // Variables related to scrolling the background
    [SerializeField] float backgroundScrollSpeed = 0.02f;
    Material myMaterial;
    Vector2 offset;

    void Start()
    {
        // Sets the material and offset
        myMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(0f, backgroundScrollSpeed);
    }

    void Update()
    {
        // Keeps scrolling the background
        myMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
