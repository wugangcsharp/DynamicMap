using UnityEngine;
using System.Collections;
/// <summary>
/// Terrain enity.
/// </summary>
public class TerrainEnity : MonoBehaviour {
	
	/// <summary>
	/// Gets or sets the position_ vector3.
	/// </summary>
	/// <value>
	/// The position_ vector3.
	/// </value>
	public Vector3 P_Vector3{get;set;}
	/// <summary>
	/// Gets or sets the Scale_ vector3.
	/// </summary>
	/// <value>
	/// The Scale__ vector3.
	/// </value>
	public Vector3 S_Vector3{get;set;}
	
	/// <summary>
	/// Initializes a new instance of the <see cref="TerrainEnity"/> class.
	/// </summary>
	/// <param name='maxX'>
	/// 用于实例下一个地形的x轴坐标
	/// </param>
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
