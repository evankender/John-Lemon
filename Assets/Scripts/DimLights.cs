using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimLights : MonoBehaviour
{
    Light myLight;
    void Start()
    {
      myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        float lightFactor = .01f;
        myLight.intensity = Mathf.Lerp(myLight.intensity, 0f, lightFactor*Time.deltaTime);
    }
}
