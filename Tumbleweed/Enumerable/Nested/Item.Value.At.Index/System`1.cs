using Tumbleweed.Scalar.Immutable;
using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using Scalar = Tumbleweed.Scalar;
using System = System;

namespace Tumbleweed.Enumerable.Nested.Item.Value.At.Index;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<SCG::IEnumerable<T>> enumerable,
		Any<System::Int32> index
	) : base
	(
		new Enumerable::Scalar.Value<T>(
			new Tumbleweed.Scalar.Immutable.From.Enumerable.At.Index.System<SCG::IEnumerable<T>>(
				enumerable,
				index))
	)
	{
	}
}