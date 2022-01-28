using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Player.Scripts;
using AosSdk.Core.Scripts;

public class CameraSwitchContoller : MonoBehaviour
{
    [SerializeField] private SwitchCameraObject[] _switchCameraObjects;
    [SerializeField] private GameObject _inventoryViev;

    private void Awake()
    {
        foreach (var switchCameraObject in _switchCameraObjects)
        {
            switchCameraObject.SwitchCameraEvent += OnDisablePlayerCamera;
        
        }
    }
    private void OnDisablePlayerCamera()
    {
        Player.Instance.EnableCamera(false);
        _inventoryViev.SetActive(true);
    }

}
