using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject up;
    public GameObject on;
    public bool isUp;
    public bool isOn;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        up.SetActive(isUp);
        on.SetActive(isOn);
        if (isOn)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        isUp = !isUp;
        isOn = !isOn;
        up.SetActive(isUp);
        on.SetActive(isOn);
        audio.Play();
    }
}
