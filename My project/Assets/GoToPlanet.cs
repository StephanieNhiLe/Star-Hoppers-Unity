using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;


public class GoToPlanet : MonoBehaviour
{
    public string sceneName;
    private InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {
       // SphereCollider collider = gameObject.GetComponent<SphereCollider>();
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        foreach (var item in devices)
        {

        }

        if(devices.Count > 0) {
            targetDevice = devices[0];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.name == "Hand") {
            SceneManager.LoadScene(sceneName);
        }
    }

    private void OnTriggerStay(Collider col) 
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        if (primaryButtonValue) {
            SceneManager.LoadScene(sceneName);
        }
    }
}
