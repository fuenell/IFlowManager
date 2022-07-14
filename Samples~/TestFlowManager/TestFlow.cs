using FlowManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFlow : MonoBehaviour, IFlow
{
    public GameObject obj;

    private void Awake()
    {
        obj.SetActive(false);
    }

    public void Enter()
    {
        obj.SetActive(true);
    }

    public void Exit()
    {
        obj.SetActive(false);
    }
}
