using System.Linq;
using UnityEngine;

/// <summary>
/// 生成两个序列的差集。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.except?view=netframework-4.6.1
/// </summary>
public class Except : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 2, 3, 4, 5, 6 };
		int[] number2 = { 2, 3, 5 };
		foreach (var number in numbers.Except(number2))
			Debug.Log(number);
		Debug.Log("***************分割线***************");
		foreach (var number in number2.Except(numbers))
			Debug.Log(number);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
