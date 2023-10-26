using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Enumerable.Slice.In.Range;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<T> origin,
		System::Int32 start,
		System::Int32 end
	) : this
	(
		origin,
		new Scalar::With.Value<Int32>(start),
		new Scalar::With.Value<Int32>(end)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> origin,
		Scalar::Any<Int32> start,
		Scalar::Any<Int32> end
	) : base
	(
		new Enumerable::Function.Result<T>(
			() => Function(origin, start, end))
	)
	{
	}

	private static SCG::IEnumerable<T> Function
	(
		SCG::IEnumerable<T> origin,
		Scalar::Any<Int32> start,
		Scalar::Any<Int32> end
	) =>
	(
		Function(origin, start.Value, end.Value)
	);
	
	private static SCG::IEnumerable<T> Function
	(
		SCG::IEnumerable<T> origin,
		Int32 start,
		Int32 end
	) =>
	(
		origin.Skip(start).Take(end - start + 1)
	);
}