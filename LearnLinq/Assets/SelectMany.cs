using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
/// <summary>
/// 对序列中的每个元素投影IEnumerable<T>包含生成它的源元素的索引。 每个中间序列的每个元素调用结果选择器函数和生成的值合并到一个一维序列，并返回。
/// 通俗的讲就是序列元素也是序列，将他们合并到一维序列
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.selectmany?view=netstandard-2.1
/// </summary>
public class SelectMany : MonoBehaviour
{
	class PetOwner
	{
		public string Name { get; set; }
		public List<Pet> Pets { get; set; }
	}
	class Pet
	{
		public string Name { get; set; }
		/// <summary>
		/// 品种
		/// </summary>
		public string breed { get; set; }
	}
	/// <summary>
	/// 筛选出品种breed1的数据
	/// </summary>
	void Start()
	{
		PetOwner[] petOwners = {
			new PetOwner { Name = "Jorlin", Pets = new List<Pet>{
				new Pet{ Name = "dog1", breed = "breed1"},
				new Pet{ Name = "dog2", breed = "breed2"},
			} },
			new PetOwner { Name = "Tom", Pets = new List<Pet>{
				new Pet{ Name = "dog3", breed = "breed1"},
				new Pet{ Name = "dog4", breed = "breed1"},
			} },
		};

		var query = petOwners.SelectMany(
			owner => owner.Pets,
			(owner, pet) => new { owner, pet}
			).Where(ownerAndPet => ownerAndPet.pet.breed == "breed1")
			.Select(ownerAndPet => new {
				Owner = ownerAndPet.owner.Name,
				Pet = ownerAndPet.pet.Name
			});
		foreach (var obj in query)
			Debug.LogFormat("Owner: {0}, pet: {1}", obj.Owner, obj.Pet);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
