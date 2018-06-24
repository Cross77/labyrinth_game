using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery : MonoBehaviour {

    private Text Counter;

    public string Label = "BTR: ";

    void Start() {
        Counter = GameObject.FindGameObjectWithTag("GUICounter").GetComponent<Text>();
        Counter.text = Label + leaveBattery();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Counter.text = "Baterie: " + leaveBattery();
            Destroy(gameObject);
            //return;
        }
        /*
        if (leaveBattery() == 1)
        {
            Debug.Log("Zakonczono poziom");
        }
        else
        {
            Destroy(gameObject);
        }*/
    }

    int leaveBattery()
    {
        Battery[] batteries = Component.FindObjectsOfType<Battery>();
        return batteries.Length;
    }
}
