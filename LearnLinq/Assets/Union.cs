using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 生成两个序列的并集
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.union?view=netstandard-2.1
/// </summary>
public class Union : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers1 = { 1,3,5};
		int[] numbers2 = { 2, 4, 6 ,5};
		foreach (var number in numbers1.Union(numbers2))
			Debug.Log(number);
		//输出结果1,3,5,2,4,6
	}

	// Update is called once per frame
	void Update()
	{

	}
}
