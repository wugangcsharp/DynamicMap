using UnityEngine;
using System.Collections;

public class TerrainController : MonoBehaviour {
	private Transform m_transform;
	// Use this for initialization
	void Start () {
		m_transform=this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		m_transform.Translate(Vector3.left*Time.deltaTime);
	}
	void OnBecameInvisible(){
        GameManager.m_Current_Terrain-=1;
        GameManager.m_timer=0;
        Destroy(this.gameObject);
	}
	void OnTriggerEnter(){
        //GameManager.m_Current_Terrain-=1;
        //GameManager.m_timer=0;
        //Destroy(this.gameObject);
	}

}
