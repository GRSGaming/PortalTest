using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour {

	public Camera cameraAB;
	public Camera cameraBA;
	public Camera cameraBC;
	public Camera cameraCB;


	public Material cameraMatAB;
	public Material cameraMatBA;
	public Material cameraMatBC;
	public Material cameraMatCB;

	// Use this for initialization
	void Start () {
		/*if (cameraAB.targetTexture != null)
		{
			cameraAB.targetTexture.Release();
		}
		cameraAB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
		cameraMatA.mainTexture = cameraAB.targetTexture;

		if (cameraBA.targetTexture != null)
		{
			cameraBA.targetTexture.Release();
		}
		cameraBA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
		cameraMatB.mainTexture = cameraBA.targetTexture;

		if (cameraBC.targetTexture != null)
		{
			cameraBC.targetTexture.Release();
		}
		cameraBC.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
		cameraMatC.mainTexture = cameraBC.targetTexture;*/
		AssingMat(cameraAB, cameraMatAB);
		AssingMat(cameraBA, cameraMatBA);
		AssingMat(cameraBC, cameraMatBC);
		AssingMat(cameraCB, cameraMatCB);
	}

	void AssingMat(Camera cam,Material mat)
    {
		if (cam.targetTexture != null)
		{
			cam.targetTexture.Release();
		}
		cam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
		mat.mainTexture = cam.targetTexture;
	}
	
}
