using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 返回序列中的单个特定元素。
/// 返回序列的唯一元素；如果该序列并非恰好包含一个元素，则会引发异常。
/// 返回序列中满足指定条件的唯一元素；如果有多个这样的元素存在，则会引发异常。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.single?view=netframework-4.6.1
/// </summary>
public class Single : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1,2,3};
		int[] numbers2 = { 1};
		//numbers不止包含一个元素,这段代码将会报错
		try
		{
			Debug.Log(numbers.Single());
		}
		catch {
			Debug.Log("无法对numbers使用Single()");
		}
		Debug.Log(numbers2.Single());
		//这次可以，因为只有一个元素满足以下条件
		Debug.Log(numbers.Single(number => number == 2));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
