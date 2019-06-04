using System.Linq;
using UnityEngine;
/// <summary>
/// 返回序列中指定索引处的元素。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.elementat?view=netframework-4.6.1
/// </summary>

public class ElementAt : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 1, 2, 3 };
		var random = new System.Random(System.DateTime.Now.Millisecond);
		Debug.Log(numbers.ElementAt(random.Next(0, numbers.Length)));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
