using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

namespace RAIJIN
{
	public class SystemEnd : MonoBehaviour
	{
		private CanvasGroup groupFianl;
		private TextMeshProUGUI textSubTittle;
		private Button btnRestart;
		private Button btnNext;



		private void Awake()
		{
			groupFianl = GameObject.Find("�C����������").GetComponent<CanvasGroup>();
			textSubTittle = GameObject.Find("�����лy").GetComponent<TextMeshProUGUI>();
			btnRestart = GameObject.Find("���s�}�l���s").GetComponent<Button>();
			btnNext = GameObject.Find("�U�@�����s").GetComponent<Button>();

			btnRestart.onClick.AddListener(Restart);
			btnNext.onClick.AddListener(Quit);


		}


		public void ShowEndTittle(string subTittle)
		{
			textSubTittle.text = subTittle;
			StartCoroutine(ShowCanvas());
		}

		private IEnumerator ShowCanvas()
		{
			for (int i = 0; i < 10; i++)
			{
				groupFianl.alpha += 0.1f;
				yield return new WaitForSeconds(0.01f);
			}

			groupFianl.interactable = true;
			groupFianl.blocksRaycasts = true;

		}


		private void Restart()
		{
			string nameCurrent = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(nameCurrent);
		}

		private void Quit()
		{
			Application.Quit();
		}


	}

}


