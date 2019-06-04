using System.Linq;
using UnityEngine;
/// <summary>
/// 返回序列中的非重复元素。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.distinct?view=netframework-4.6.1
/// </summary>
public class Distinct : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 1, 1, 3, 4, 5, 3, 4, 6 };
		foreach (var number in numbers.Distinct())
			Debug.Log(number);//print: 1,3,4,5,6
	}

	// Update is called once per frame
	void Update()
	{

	}
}
