using UnityEngine;
using System.Collections;

public class TerrainEnity : MonoBehaviour {

	public Vector3 P_Vector3{get;set;}
	public Vector3 S_Vector3{get;set;}
	
	public  TerrainEnity(float maxX)
	{
		float x,y,z;
		
		#region 大小
		x=Random.Range(1f,7.5f);
		y=1;
		z=1;
		#endregion
		S_Vector3=new Vector3(x,y,z);
		
		#region 位置
		x=maxX;
		y=Random.Range(-4.370596f,-3.120014f);
		z=0;
		#endregion
		P_Vector3=new Vector3(x+S_Vector3.x/2,y,z);
		
			
		
	}
}
