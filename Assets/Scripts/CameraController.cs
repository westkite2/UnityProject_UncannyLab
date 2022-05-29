using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float cameraMoveSpeed;
    private float camHeight;
    private float camWidth;
    private Vector2 mapSize;
    private Vector2 mapCenter;
    public GameObject objPlayer;

    private void Awake()
    {
        cameraMoveSpeed = 3f;
        mapSize = new Vector2(6.1f, 5.1f);
        camHeight = Camera.main.orthographicSize;
        camWidth = camHeight * Screen.width / Screen.height;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Get camera number
        switch (gameObject.name)
        {
            case "Camera1":
                mapCenter = new Vector2(-4.5f, 0);
                break;
            case "Camera2":
                mapCenter = new Vector2(4.5f, 0);
                break;
        }
    }

    private void TrackPlayer()
    {
        // Follow player
        transform.position = Vector3.Lerp(transform.position, objPlayer.transform.position, Time.deltaTime * cameraMoveSpeed);
        
        // Limit camera area
        float lx = mapSize.x - camWidth;
        float ly = mapSize.y - camHeight;
        float clampX = Mathf.Clamp(transform.position.x, -lx + mapCenter.x, lx + mapCenter.x);
        float clampY = Mathf.Clamp(transform.position.y, -ly + mapCenter.y, ly + mapCenter.y);
        
        // Modify camera position
        transform.position = new Vector3(clampX, clampY, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        TrackPlayer();
    }
}
