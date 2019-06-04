using System.Linq;
using UnityEngine;
/// <summary>
/// 返回序列中第一个元素
/// 返回序列中满足条件的第一个元素
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.first?view=netframework-4.6.1
/// </summary>
public class First : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 2, 3 };
		Debug.Log(numbers.First());
		Debug.Log(numbers.First(number => number > 1));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
