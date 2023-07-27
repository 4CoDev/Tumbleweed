using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Enumerable.Item.From.Right.By.Length;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<T> enumerable,
		System::Int32 length
	) : this
	(
		enumerable,
		new Scalar::Of.Value<System::Int32>(length)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> enumerable,
		Scalar::Any<Int32> length
	) : this
	(
		new SCG::List<T>(enumerable),
		length
	)
	{
	}
	
	public System
	(
		ICollection<T> collection,
		Scalar::Any<Int32> length
	) : base
	(
		new Enumerable::Scalar.Value<T>(
			new Scalar::Function.Result<SCG::IEnumerable<T>>(
				() => collection.Skip(collection.Count - length.Value)))
	)
	{
	}
}