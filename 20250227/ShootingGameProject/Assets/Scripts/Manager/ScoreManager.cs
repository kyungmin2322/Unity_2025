using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	#region Singleton
	public static ScoreManager Instance = null;

	private void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
		}
	}
	#endregion

	// Inspector
	public Text currentScoreUI;
	public Text bestScoreUI;

	// Inner
	private int currenetScore;
	private int bestScore;

	// 현재 점수에 대한 프로퍼티 설계
	// 값에 대한 접근과 설정을 변수처럼 진행할 수 있다.
	public int Score
	{
		get
		{
			return currenetScore;
		}

		set
		{
			// 1. 전달받은 값이 현재의 점수로 설정
			currenetScore = value;
			// 2. UI에 해당 값이 적용
			currentScoreUI.text = $"현재 점수 : {currenetScore}";

			// 현재의 점수가 최고 점수를 넘었다면
			if(currenetScore > bestScore)
			{
				// 그 점수가 최고 점수로 설정되며
				bestScore = currenetScore;
				// UI에 갱신
				bestScoreUI.text = $"최고 점수 : {bestScore}";
				// 내부 데이터에도 그 수치를 적용
				PlayerPrefs.SetInt("Best Score", bestScore);
			}
		}
	}
}
