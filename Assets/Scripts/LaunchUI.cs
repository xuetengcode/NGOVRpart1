using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class LaunchUI : MonoBehaviour
{
    [SerializeField]
    private Button HostButton;
    [SerializeField]
    private Button ClientButton;

    private void Awake()
    {
        HostButton.onClick.AddListener(() =>
        {
            //add code here
            NetworkManager.Singleton.StartHost();

        });

        ClientButton.onClick.AddListener(() =>
        {
            //add code here
            NetworkManager.Singleton.StartClient();
        });
    }
}