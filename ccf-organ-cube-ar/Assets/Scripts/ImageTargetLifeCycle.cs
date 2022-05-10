using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTargetLifeCycle : MonoBehaviour
{
    [SerializeField] private DefaultObserverEventHandler handler;

    private void Awake()
    {
        handler = GetComponent<DefaultObserverEventHandler>();
        handler.OnTargetLost.AddListener(delegate
        {
            Destroy();
        });

    }
    public void Destroy()
    {
        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();
        foreach (var item in renderers)
        {
            item.enabled = false;
        }
    }
}
