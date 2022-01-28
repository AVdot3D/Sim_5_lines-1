using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using UnityEngine.Events;
using AosSdk.Core.Scripts;

using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Scripts;
using UnityEngine;
using AosSdk.Core.Player.Scripts;
using UnityEngine.Events;

//[AosObject(name: "Дверь")]
//public class SwitchCameraObject : AosObjectBase, IClickAble
//{
//    public UnityAction SwitchCameraEvent;

//    [SerializeField] private GameObject _camera;

//    [AosEvent(name: "Телепорт к объекту событие")]
//    public event AosEventHandler OnTeleportToObject;

//    [AosAction(name: "Телепорт к объекту")]
//    public void StartTeleporting()
//    {
//        _camera.SetActive(true);
//        OnTeleportToObject?.Invoke();
//    }
//    public void OnClicked()
//    {
//        StartTeleporting();

//    }

//}

public class SwitchCameraObject : MonoBehaviour, IClickAble
{
    public UnityAction SwitchCameraEvent;
    [SerializeField] private GameObject _camera;
    public void OnClicked()
    {
        SwitchCamera();
    }
    private void SwitchCamera()
    {
        print("Interract");
        _camera.SetActive(true);

        SwitchCameraEvent?.Invoke();
    }

}
