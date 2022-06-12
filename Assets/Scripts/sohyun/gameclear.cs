using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class gameclear : MonoBehaviour
{
    public VideoPlayer vp;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("VideoPlay",2);
        Invoke("returntitle",17);
    }

    void VideoPlay()
    {
        vp.Play();
    }

    void returntitle()
    {
        SceneManager.LoadScene("GameStart");
    }
}
