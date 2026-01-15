using UnityEngine;

public class TourelleController : MonoBehaviour
{
    [SerializeField]
    private Transform _tourelleTransform;

    [SerializeField]
    private float _rotateSpeed = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _tourelleTransform.Rotate(0, _rotateSpeed * Time.deltaTime, 0);
    }
}
