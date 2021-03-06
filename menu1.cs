using ExitGames.Client.Photon;
using Photon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using UnityEngine;


class FengGameManagerMKII : Photon.MonoBehaviour
{
	public static object[] settings;
	public Texture2D fontexture;
		
		
	public void loadconfig()
	
	{
		object[] objArray = new object[500];
		objArray[276] = PlayerPrefs.GetString("TextColor", "<color=cyan>");
		objArray[275] = PlayerPrefs.GetString("TextColor1", "00FFFF");
		objArray[277] = PlayerPrefs.GetFloat("colorgasR1", 0f);
		objArray[278] = PlayerPrefs.GetFloat("colorgasG1", 255f);
		objArray[279] = PlayerPrefs.GetFloat("colorgasB1", 255f);
		objArray[280] = PlayerPrefs.GetFloat("colorgasA1", 1f);
		objArray[281] = PlayerPrefs.GetFloat("colorgasR2", 0f);
		objArray[282] = PlayerPrefs.GetFloat("colorgasG2", 0f);
		objArray[283] = PlayerPrefs.GetFloat("colorgasB2", 0f);
		objArray[284] = PlayerPrefs.GetFloat("colorgasA2", 0.8f);
		objArray[285] = PlayerPrefs.GetInt("Window1", 1);
		objArray[286] = PlayerPrefs.GetInt("Windowtexture", 1);
	}

	public void OnGUI()
	{
		
		if ((IN_GAME_MAIN_CAMERA.gametype == GAMETYPE.STOP) && (Application.loadedLevelName != "characterCreation"))
    {			
			else if (IN_GAME_MAIN_CAMERA.gametype != GAMETYPE.STOP)
      {
		
				else if ((this.inputManager != null) && this.inputManager.menuOn)
				{
						
					if (((int) settings[0x40]) != 6)
					{

						float num7 = (((float) Screen.width) / 2f) - 320f;
						float num8 = (((float) Screen.height) / 2f) - 250f;
						GUI.DrawTexture(new Rect(num7 - 28f, num8 +2, 726f, 496f), fontexture, ScaleMode.StretchToFill);
						UnityEngine.Object.Destroy(fontexture);
						fontexture = new Texture2D(1, 1, TextureFormat.ARGB32, false);
						GUI.backgroundColor = new Color((float) settings[277], (float) settings[278], (float) settings[279], (float) settings[280]);
									
						if (((int) settings[286]) == 0)
						{
							fontexture.SetPixel(0, 0, new Color((float) settings[281], (float) settings[282], (float) settings[283], (float) settings[284]));
							fontexture.Apply();
						}
						else
						{
							WWW link = new WWW("File://" + Application.dataPath + "/image.jpg");
							fontexture = link.texture;
							fontexture.Apply();
						}

						if (GUI.Button(new Rect(num7 + 560f, num8 + 435f, 100f, 25f), (string)settings[276]+ "Стиль меню</color>", "box"))
						{
							settings[0x40] = 21;
						}
						else if (((int) settings[0x40]) == 21)
						{
							bool flag35;
							bool flag36;
							GUI.Label(new Rect(num7 + 250f, num8 + 45f, 50f, 22f),(string)settings[276]+ "Фон:</color>" , "Label");
							GUI.Label(new Rect(num7 + 250f, num8 + 70f, 100f, 22f),(string)settings[276]+ "Включить фон:</color>" , "Label");
							flag35 = false;
												if (((int) settings[286]) == 1)
												{
														flag35 = true;
												}
												flag36 = GUI.Toggle(new Rect(num7 + 350f, num8 + 70f, 22f, 22f), flag35, "");
												if (flag35 != flag36)
												{
														if (flag36)
														{
																settings[286] = 1;
														}
														else
														{
																settings[286] = 0;
														}
												}
									
												GUI.Label(new Rect(num7 + 250f, num8 + 91f, 20f, 22f), "<color=red><b>o</b></color>", "Label");
						            GUI.Label(new Rect(num7 + 250f, num8 + 116f, 20f, 22f), "<color=green><b>o</b></color>", "Label");
						            GUI.Label(new Rect(num7 + 250f, num8 + 141f, 20f, 22f), "<color=blue><b>o</b></color>", "Label");
						            GUI.Label(new Rect(num7 + 250f, num8 + 166f, 20f, 22f), "<color=white><b>o</b></color>", "Label");
						            settings[281] = GUI.HorizontalSlider(new Rect(num7 + 270f, num8 + 95f, 100f, 22f), (float) settings[281], 0f, 1f);
						            settings[282] = GUI.HorizontalSlider(new Rect(num7 + 270f, num8 + 120f, 100f, 22f), (float) settings[282], 0f, 1f);
						            settings[283] = GUI.HorizontalSlider(new Rect(num7 + 270f, num8 + 145f, 100f, 22f), (float) settings[283], 0f, 1f);
						            settings[284] = GUI.HorizontalSlider(new Rect(num7 + 270f, num8 + 170f, 100f, 22f), (float) settings[284], 0f, 1f);
												GUI.Label(new Rect(num7 + 250f, num8 + 195f, 100f, 22f),(string)settings[276]+ "Пленка:</color>" , "Label");
												flag35 = false;
												if (((int) settings[285]) == 1)
												{
														flag35 = true;
												}
												flag36 = GUI.Toggle(new Rect(num7 + 350f, num8 + 195f, 22f, 22f), flag35, "");
												if (flag35 != flag36)
												{
														if (flag36)
														{
																settings[285] = 1;
														}
														else
														{
																settings[285] = 0;
														}
												}
								
												GUI.Label(new Rect(num7 + 80f, num8 + 45f, 150f, 22f),(string)settings[276]+ "Цвет текста(RGB):</color>" , "Label");
												settings[275] = GUI.TextField(new Rect(num7 + 80f, num8 + 70f, 70f, 22f), (string)settings[275]);
												if (GUI.Button(new Rect(num7 + 152f, num8 + 70f, 22f, 22f),(string)settings[276]+ "ok</color>", "box"))
									      {
													settings[276] = "<color=#"+ (string)settings[275] + ">";
												}
												GUI.Label(new Rect(num7 + 80f, num8 + 95f, 150f, 22f),(string)settings[276]+ "Предустановки:</color>" , "Label");
												if (GUI.Button(new Rect(num7 + 80f, num8 + 120f, 22f, 22f), "<color=cyan><b>☼</b></color>" , "box"))
						            {
						               settings[276] = "<color=cyan>";
						            }
												if (GUI.Button(new Rect(num7 + 105f, num8 + 120f, 22f, 22f), "<color=#FF0505><b>☼</b></color>" , "box"))
						            {
						                settings[276] = "<color=#FF0505>";
												
						            }
												if (GUI.Button(new Rect(num7 + 130f, num8 + 120f, 22f, 22f), "<color=#FFEA05><b>☼</b></color>" , "box"))
						            {
						               settings[276] = "<color=#FFEA05>";
						            }
												if (GUI.Button(new Rect(num7 + 155f, num8 + 120f, 22f, 22f), "<color=#00F203><b>☼</b></color>", "box" ))
						            {
						               settings[276] = "<color=#00F203>";
						            }
												if (GUI.Button(new Rect(num7 + 180f, num8 + 120f, 22f, 22f), "<color=#05FF57><b>☼</b></color>" , "box"))
						            {
						               settings[276] = "<color=#05FF57>";
						            }
												if (GUI.Button(new Rect(num7 + 80f, num8 + 145f, 22f, 22f), "<color=#051AFF><b>☼</b></color>", "box" ))
						            {
													settings[276] = "<color=#051AFF>";
						            }
												if (GUI.Button(new Rect(num7 + 105f, num8 + 145f, 22f, 22f), "<color=#C405FF><b>☼</b></color>" , "box"))
						            {
													settings[276] = "<color=#C405FF>";
						            }
												if (GUI.Button(new Rect(num7 + 130f, num8 + 145f, 22f, 22f), "<color=#FF05BE><b>☼</b></color>", "box" ))
						            {
													settings[276] = "<color=#FF05BE>";
						            }
												if (GUI.Button(new Rect(num7 + 155f, num8 + 145f, 22f, 22f), "<color=#FFFFFF><b>☼</b></color>" , "box"))
						            {
													settings[276] = "<color=#FFFFFF>";
						            }
												if (GUI.Button(new Rect(num7 + 180f, num8 + 145f, 22f, 22f), "<color=black><b>☼</b></color>" , "box"))
						            {
													settings[276] = "<color=#000000>";
						            }
												GUI.Label(new Rect(num7 + 80f, num8 + 170f, 150f, 22f),(string)settings[276]+ "Цвет кнопок:</color>" , "Label");
												
												GUI.Label(new Rect(num7 + 80f, num8 + 196f, 20f, 22f), "<color=red><b>o</b></color>", "Label");
												GUI.Label(new Rect(num7 + 80f, num8 + 221f, 20f, 22f), "<color=green><b>o</b></color>", "Label");
												GUI.Label(new Rect(num7 + 80f, num8 + 246f, 20f, 22f), "<color=blue><b>o</b></color>", "Label");
												GUI.Label(new Rect(num7 + 80f, num8 + 271f, 20f, 22f), "<color=white><b>o</b></color>", "Label");
												settings[277] = GUI.HorizontalSlider(new Rect(num7 + 100f, num8 + 200f, 100f, 22f), (float) settings[277], 0f, 1f);
												settings[278] = GUI.HorizontalSlider(new Rect(num7 + 100f, num8 + 225f, 100f, 22f), (float) settings[278], 0f, 1f);
												settings[279] = GUI.HorizontalSlider(new Rect(num7 + 100f, num8 + 250f, 100f, 22f), (float) settings[279], 0f, 1f);
												settings[280] = GUI.HorizontalSlider(new Rect(num7 + 100f, num8 + 275f, 100f, 22f), (float) settings[280], 0f, 1f);
												GUI.Label(new Rect(num7 + 80f, num8 + 300f, 150f, 22f),(string)settings[276]+ "Предустановки:</color>" , "Label");
												if (GUI.Button(new Rect(num7 + 80f, num8 + 325f, 22f, 22f), "<color=cyan><b>☼</b></color>" , "box"))
							          {
						               settings[277] = 0f;
												   settings[278] = 255f;
											  	 settings[279] = 255f;
						            }
												if (GUI.Button(new Rect(num7 + 105f, num8 + 325f, 22f, 22f), "<color=#FF0505><b>☼</b></color>" , "box"))
						            {
													settings[277]= 255f;
													settings[278] = 0f;
													settings[279] = 0f;
						            }
												if (GUI.Button(new Rect(num7 + 130f, num8 + 325f, 22f, 22f), "<color=#FFEA05><b>☼</b></color>" , "box"))
						            {
													settings[277] = 255f;
													settings[278] = 255f;
													settings[279] = 0f;
						            }
												if (GUI.Button(new Rect(num7 + 155f, num8 + 325f, 22f, 22f), "<color=#00F203><b>☼</b></color>", "box" ))
						            {
													settings[277] = 0f;
													settings[278] = 255f;
													settings[279] = 0f;
						           	}
												if (GUI.Button(new Rect(num7 + 180f, num8 + 325f, 22f, 22f), "<color=black><b>☼</b></color>" , "box"))
						            {   
													settings[277] = 0f;
													settings[278] = 0f;
													settings[279] = 0f;
						            }
												if (GUI.Button(new Rect(num7 + 80f, num8 + 350f, 22f, 22f), "<color=#051AFF><b>☼</b></color>", "box" ))
						            {   
													settings[277] = 0f;
													settings[278] = 0f;
													settings[279] = 128f;
						            }
												if (GUI.Button(new Rect(num7 + 105f, num8 + 350f, 22f, 22f), "<color=#C405FF><b>☼</b></color>" , "box"))
						            {
													settings[277] = 139f;
													settings[278] = 0f;
													settings[279] = 139f;
						            }
												if (GUI.Button(new Rect(num7 + 130f, num8 + 350f, 22f, 22f), "<color=#FF05BE><b>☼</b></color>", "box" ))
						            {
													settings[277] = 255f;
													settings[278] = 0f;
													settings[279] = 255f;
						            }
												if (GUI.Button(new Rect(num7 + 155f, num8 + 350f, 22f, 22f), "<color=#FFFFFF><b>☼</b></color>" , "box"))
						            {
													settings[277] = 255f;
													settings[278] = 255f;
													settings[279] = 255f;
						            }
									}
									if (GUI.Button(new Rect(num7 + 285f, num8 + 465f, 85f, 25f), (string)settings[276]+ "Сохранить</color>"))
						      {
										PlayerPrefs.SetString("TextColor", (string) settings[276]);
										PlayerPrefs.SetString("TextColor1", (string) settings[275]);
										PlayerPrefs.SetFloat("colorgasR1", (float) settings[277]);
										PlayerPrefs.SetFloat("colorgasG1", (float) settings[278]);
										PlayerPrefs.SetFloat("colorgasB1", (float) settings[279]);
										PlayerPrefs.SetFloat("colorgasA1", (float) settings[280]);
										PlayerPrefs.SetFloat("colorgasR2", (float) settings[281]);
										PlayerPrefs.SetFloat("colorgasG2", (float) settings[282]);
										PlayerPrefs.SetFloat("colorgasB2", (float) settings[283]);
										PlayerPrefs.SetFloat("colorgasA2", (float) settings[284]);
										PlayerPrefs.SetInt("Window1", (int) settings[285]);
										PlayerPrefs.SetInt("Windowtexture", (int) settings[286]);
									}
							}
					}
				}
		}
	}
}
