﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float jump;
    /// <summary>
    /// 当前设备类型
    /// </summary>
    CurrentDevice _CurrentDevice = new CurrentDevice();

    private Rigidbody m_rigidbody;
	private bool canJump;
	private float beginX;
	private float endX;
    void Awake()
    {
#if UNITY_ANDROID
        //安卓设备
        _CurrentDevice = CurrentDevice.ANDROID;
#endif

#if UNITY_IPHONE
            //苹果设备
	       _CurrentDevice=CurrentDevice.IPHONE;
#endif

#if UNITY_STANDALONE_WIN
            //pc
	        _CurrentDevice=CurrentDevice.STANDALONEWIN;
#endif
        //webplayer
        if (Application.isWebPlayer) _CurrentDevice = CurrentDevice.WebPlayer;
        //编辑器
        if (Application.isEditor) _CurrentDevice = CurrentDevice.Editor;
    }

    void Start()
    {
		canJump=true;
        m_rigidbody = this.transform.rigidbody;
    }

    // Update is called once per frame
    void Update()
    {
		if(canJump){
	        switch (_CurrentDevice)
	        {
	            case CurrentDevice.ANDROID:
	                if (Input.touchCount > 0)
	                {
	                    m_rigidbody.AddForce(new Vector3(0, 1, 0) * jump);
						canJump=false;
	                }
	                break;
	            case CurrentDevice.Editor:
	                if (Input.GetKeyDown(KeyCode.Space))
	                {
	                    m_rigidbody.AddForce(new Vector3(0, 1, 0) * jump);
						canJump=false;
	                }
	                break;
	            default:
	                break;
	        }
		} 
    }
	void OnCollisionEnter(Collision _collision){
		if(_collision.collider.tag.CompareTo("Terrain")==0){
			canJump=true;
		}
	}
}

public enum CurrentDevice
{
    ANDROID,
    Editor,
    IPHONE,
    STANDALONEWIN,
    WebPlayer
}