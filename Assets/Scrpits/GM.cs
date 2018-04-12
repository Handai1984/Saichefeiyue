using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{

	public static  GM instante;
	public bool isGameOver;
	public SpriteRenderer mapColor;
	//获取地图的render
	private Color mcolor;
	public Transform car;
	public GameObject start;
	public GameObject reStart;
	private  Text scoreText;
	public Text highScoreText;
	public GameObject win;
	private int score = 0;
	private int hightScore;
	//谷歌广告
	
	private int countInter;
	//计数器
	private int countBanner;

	private void Awake ()
	{
		instante = this;
		isGameOver = true;
	}

	private void Start ()
	{
		car.gameObject.SetActive (true);
		car.position = this.transform.position;
		scoreText = GameObject.Find ("Score").GetComponent<Text> ();
		hightScore = PlayerPrefs.GetInt ("High", 0);

		
		 
		//查找广告脚本
		

		
		
		StartColor ();
		ShowScore ();
	}
	

	/// <summary>
	/// 改变游戏地图和背景颜色
	/// </summary>
	private void StartColor ()
	{
		mcolor = new Color (Random.Range (0, 256) / 255f, Random.Range (0, 256) / 255f, Random.Range (0, 256) / 255f);
		mapColor.color = mcolor;

		mcolor = new Color (Random.Range (0, 256) / 255f, Random.Range (0, 256) / 255f, Random.Range (0, 256) / 255f);
		Camera.main.backgroundColor = mcolor;

        
	}


	public void GameStart ()
	{
		//游戏开始
		car.position = this.transform.position;
		isGameOver = false;
		win.SetActive (false);
		start.SetActive (false);

	}

	public void ReStart ()
	{
		car.gameObject.SetActive (true);
		StartColor ();//游戏开始地图和背景颜色
		car.position = this.transform.position;
		car.rotation = this.transform.rotation;
		isGameOver = false;
		score = 0;
		highScoreText.gameObject.SetActive (false);
		reStart.SetActive (false);
	}

	public void AddScore ()
	{
		score += 1;
	}

	public void ShowScore ()
	{
		int temp = score / 5;
		scoreText.text = temp + "";
		if (temp > hightScore) {
			hightScore = temp;
			PlayerPrefs.SetInt ("High", hightScore);
		}
	}

	public void ShowHihgScore ()
	{
		hightScore = PlayerPrefs.GetInt ("High", hightScore);
		highScoreText.text = "最高分：" + hightScore + "";
	}

   
	
	
	
}
