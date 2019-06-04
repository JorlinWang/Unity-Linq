using System.Linq;
using UnityEngine;
/// <summary>
/// 计算平均值，可计算包含null的可空值类型
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.average?view=netframework-4.6.1
/// </summary>
public class Average : MonoBehaviour
{
	class Pet
	{
		public string Name;
		public int Age;
	}
	// Use this for initialization
	void Start()
	{
		Pet[] pets = {
			new Pet{ Name = "a", Age = 1},
			new Pet{ Name = "b", Age = 2},
			new Pet{ Name = "c", Age = 3},
		};
		int?[] numbers = { 1, 2, null, 4, 3 };
		Debug.Log(pets.Average(pet => pet.Age));
		double? average = numbers.Average();
		Debug.Log(average);
	}


	// Update is called once per frame
	void Update()
	{

	}
}
