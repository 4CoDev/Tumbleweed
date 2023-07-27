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
		Scalar::Any<System::Int32> index
	) : base
	(
		new Enumerable::Scalar.Value<T>(
			new Scalar::From.Enumerable.At.Index.System<SCG::IEnumerable<T>>(
				enumerable,
				index))
	)
	{
	}
}