using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Enumerable.Item.From.Left.By.Length;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<T> enumerable,
		Any<System::Int32> length
	) : this
	(
		new SCG::List<T>(enumerable),
		length
	)
	{
	}
	
	public System
	(
		SCG::ICollection<T> list,
		Any<Int32> length
	) : base
	(
		new Enumerable::Scalar.Value<T>(
			new Actual<SCG::IEnumerable<T>>(
				() => list.Take(length.Value)))
	)
	{
	}
}