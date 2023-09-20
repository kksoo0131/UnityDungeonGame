using UnityEngine;

public class UI : MonoBehaviour
{
    protected UIManager _manager;

    private void Start()
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
