using System;
using UnityEngine;
                
class FengGameManagerMKII : Photon.MonoBehaviour
{ 
	public static object[] settings;
	void loadconfig()
  {
	object[] objArray = new object[500];
	objArray[271] = PlayerPrefs.GetFloat("colorgasR", 1f);
	objArray[272] = PlayerPrefs.GetFloat("colorgasG", 1f);
	objArray[273] = PlayerPrefs.GetFloat("colorgasB", 1f);
	objArray[274] = PlayerPrefs.GetFloat("colorgasA", 0.5f);
  } 
  public void OnGUI()
  {   
	else if ((this.inputManager != null) && this.inputManager.menuOn)
	{
		if (((int) settings[0x40]) == 2)
		{
			GUI.Label(new Rect(num7 + 430f, num8 + 360f, 80f, 22f), customcolor + "Цвет газа:</color>", "Label");
			Texture2D colorgas1;
			Color colorgas;
			colorgas1 = new Texture2D(1, 1, TextureFormat.ARGB32, false);
			colorgas1.SetPixel(0, 0, new Color((float) settings[271], (float) settings[272], (float) settings[273], (float) settings[274]));
			colorgas = new Color((float) settings[271], (float) settings[272], (float) settings[273], (float) settings[274]);
			GUI.Label(new Rect(num7 + 430f, num8 + 381f, 20f, 22f), "<color=red><b>o</b></color>", "Label");
			GUI.Label(new Rect(num7 + 430f, num8 + 401f, 20f, 22f), "<color=green><b>o</b></color>", "Label");
			GUI.Label(new Rect(num7 + 430f, num8 + 421f, 20f, 22f), "<color=blue><b>o</b></color>", "Label");
			GUI.Label(new Rect(num7 + 430f, num8 + 441f, 20f, 22f), "<color=white><b>o</b></color>", "Label");
			settings[271] = GUI.HorizontalSlider(new Rect(num7 + 450f, num8 + 385f, 100f, 22f), (float) settings[271], 0f, 1f);
			settings[272] = GUI.HorizontalSlider(new Rect(num7 + 450f, num8 + 405f, 100f, 22f), (float) settings[272], 0f, 1f);
			settings[273] = GUI.HorizontalSlider(new Rect(num7 + 450f, num8 + 425f, 100f, 22f), (float) settings[273], 0f, 1f);
			settings[274] = GUI.HorizontalSlider(new Rect(num7 + 450f, num8 + 445f, 100f, 22f), (float) settings[274], 0f, 1f);
			GameObject.Find("3dmg_smoke").GetComponent<ParticleSystem>().startColor = colorgas;
			colorgas1.Apply();
			GUI.DrawTexture(new Rect(num7 + 513f, num8 + 365f, 30f, 12f), colorgas1, ScaleMode.StretchToFill);
			UnityEngine.Object.Destroy(colorgas1);
		}
		
		if (GUI.Button(new Rect(num7 + 285f, num8 + 465f, 85f, 25f), "Сохранить"))
		{
			PlayerPrefs.SetFloat("colorgasR", (float) settings[271]);
			PlayerPrefs.SetFloat("colorgasG", (float) settings[272]);
			PlayerPrefs.SetFloat("colorgasB", (float) settings[273]);
			PlayerPrefs.SetFloat("colorgasA", (float) settings[274]);
		}
	}
}
