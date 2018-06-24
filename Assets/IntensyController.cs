using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntensyController : MonoBehaviour
{

    public Text Counter;
    private string Label = "INT: ";
    private int Intensity = 100;
    private float minWaitTime = 1;
    private float maxWaitTime = 0.5f;

    // Use this for initialization
    void Start () {

        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            Intensity--;
            Counter.text = Label + Intensity;
            //testLight.enabled = !testLight.enabled;
            //testLight.intensity = Random.Range(minIntensity, maxIntensity);

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
