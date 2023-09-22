using System;
using UnityEngine;

public class UI : MonoBehaviour
{
    protected UIManager _manager;

    public virtual void Start()
    {
        _manager = UIManager.Instance;
    }
    public virtual void OnUI() 
    {
        gameObject.SetActive(true);
    }
    public virtual void OffUI()
    {
        gameObject.SetActive(false);
    }
}
