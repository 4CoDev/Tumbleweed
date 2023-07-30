using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
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
		new Value<System::Int32>(length)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> enumerable,
		Any<Int32> length
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
		Any<Int32> length
	) : base
	(
		new Enumerable::Scalar.Value<T>(
			new Actual<SCG::IEnumerable<T>>(
				() => collection.Skip(collection.Count - length.Value)))
	)
	{
	}
}