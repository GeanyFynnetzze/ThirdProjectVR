using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class KickScript : MonoBehaviour
{
    public AudioSource source;
    private InputDevice target;
    public PrimaryButtonWatcher watcher;
    // Start is called before the first frame update
    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        source = GetComponent<AudioSource>();
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics RCC = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(RCC, devices);
        if(devices.Count > 0){
            target = devices[0];
        }
    }
    public void onPrimaryButtonEvent(bool pressed)
    {
        if(pressed){
            source.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        target.TryGetFeatureValue(CommonUsages.primaryButton, out bool triggerValue);
        if(triggerValue){
            //source.Play();
        }
        
    }
}
