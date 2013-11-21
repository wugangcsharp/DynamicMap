using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameManager : MonoBehaviour {
	public Transform m_terrain;
	
	/// <summary>
	/// 当前地形个数
	/// </summary>
	public static int m_Current_Terrain;
	/// <summary>
	/// 生成地形时间间隔
	/// </summary>
	public static float m_timer=1f;
	/// <summary>
	/// 地形总个数
	/// </summary>
	private int m_MaxTerrainCount=10;
	void Start () {
		//获取当前地形个数
		m_Current_Terrain=GameObject.FindGameObjectsWithTag("Terrain").Length;
	}
	
	// Update is called once per frame
	void Update () {
		m_timer-=Time.deltaTime;
		if(m_Current_Terrain<m_MaxTerrainCount && m_timer<=0){
			m_timer=3;
			float maxX=GetMaxX();
			TerrainEnity terrainEnity=new TerrainEnity(maxX);
			//设置地形大小
			m_terrain.localScale=terrainEnity.S_Vector3;
			//实例化地形
			Instantiate(m_terrain,terrainEnity.P_Vector3,Quaternion.identity);
			//地形个数+1
			m_Current_Terrain++;
		}
	}
	
	/// <summary>
	/// 获取地形中最大的X
	/// </summary>
	/// <returns>
	/// The max x.
	/// </returns>
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