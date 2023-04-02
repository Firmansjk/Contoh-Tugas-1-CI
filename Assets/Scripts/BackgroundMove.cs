using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] public float backgroundSpeed;

    private Transform _backGround;
    // Start is called before the first frame update
    void Start()
    {
        _backGround = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MovingLoop();
    }

    private void MovingLoop()
    {
        _backGround.transform.position -= new Vector3(backgroundSpeed * Time.deltaTime, 0, 0);

        if (_backGround.transform.position.x <= -38f)
        {
            _backGround.transform.position = new Vector3(backgroundSpeed * Time.deltaTime, 0, 0);
        }
    }
}
