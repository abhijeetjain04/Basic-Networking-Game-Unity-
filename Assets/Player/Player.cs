using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    private Vector3 inputValue;
	
	void Update ()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        inputValue.x = CrossPlatformInputManager.GetAxis("Vertical");
        inputValue.y = 0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Horizontal");
        
        transform.Translate(inputValue);
	}
    public override void OnStartLocalPlayer()
    {
        GetComponentInChildren<Camera>().enabled = true;
    }
}
