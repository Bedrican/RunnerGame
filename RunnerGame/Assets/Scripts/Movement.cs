using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Movement : MonoBehaviour
{
    [SerializeField]private PlayerDataPrefs _playerPrefs;
    private float _playerSpeed;
    private float _playerDragSpeed;
    private Camera _camera;
    private Vector3 _firstPos;
    private Vector3 _endPos;
    private float _xPos;
    
    void Start()
    {
        Actions.OnPowerUp += PowerUp;
        _playerSpeed = _playerPrefs.playerForwardSpeed;
        _playerDragSpeed = _playerPrefs.playerDragSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
       
    }

    private void Move()
    {
        transform.Translate(0,0,_playerSpeed*Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            _firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            _endPos = Input.mousePosition;
            float farkX = _endPos.x - _firstPos.x;
            
            transform.Translate(farkX * Time.deltaTime * _playerDragSpeed, 0 , 0);
        }
        var position = transform.position;
        _xPos = Mathf.Clamp(position.x, -3.5f, 3.5f);
        position = new Vector3(_xPos, position.y, position.z);
        transform.position = position;
    }


    public void PowerUp()
    {
        StartCoroutine(PowerUps());
    }

    IEnumerator PowerUps()
    {
        _playerSpeed += 10;
        yield return new WaitForSeconds(5f);
        _playerSpeed -= 10;
    }
}
