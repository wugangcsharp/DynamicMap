using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour {
	public Transform m_terrain;
	
	
	public static int m_Current_Terrain;
	public static float m_timer=3;
	
	private int m_MaxTerrainCount=5;
	// Use this for initialization
	void Start () {
		m_Current_Terrain=GameObject.FindGameObjectsWithTag("Terrain").Length;
	}
	
	// Update is called once per frame
	void Update () {
		m_timer-=Time.deltaTime;
		if(m_Current_Terrain<m_MaxTerrainCount && m_timer<=0){
			m_timer=3;
			float maxX=GetMaxX();
			TerrainEnity terrainEnity=new TerrainEnity(maxX);
			m_terrain.localScale=terrainEnity.S_Vector3;
			Instantiate(m_terrain,terrainEnity.P_Vector3,Quaternion.identity);
			m_Current_Terrain++;
		}
	}
	
	float GetMaxX(){
		GameObject [] obj=GameObject.FindGameObjectsWithTag("Terrain");
        float p_X = -100, s_X = 0;
		for (int i = 0; i < obj.Length; i++) {
            if (p_X <= obj[i].transform.position.x)
            {
                p_X = obj[i].transform.position.x;
                s_X = obj[i].transform.localScale.x;
            }
		}
        return p_X + s_X;
	}
}