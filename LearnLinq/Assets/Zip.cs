using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 通过使用指定的谓词函数合并两个序列。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.zip?view=netstandard-2.1
/// 
/// 该方法将合并第一个序列与第二个序列中具有相同的索引的元素，
/// 每个的元素。 如果序列不具有相同的元素数，方法将合并序列，
/// 直到它达到其中之一的末尾。 例如，如果一个序列包含三个元素，
/// 并且另一个具有四个，所产生的序列必须只有三个元素。
/// </summary>

public class Zip : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers1 = { 1, 2, 3 };
		string[] strs1 = { "a", "b" };
		//由于strs1只有2个元素，所以只执行到index为1
		foreach (var item in numbers1.Zip(strs1, (number, str) => str + number))
			Debug.Log(item);
		//输出结果a1, b2
	}

	// Update is called once per frame
	void Update()
	{

	}
}
