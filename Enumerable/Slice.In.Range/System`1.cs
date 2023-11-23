using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;
using Property = Tumbleweed.Property.Output;

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
		new Property::With.Value.One<Int32>(start),
		new Property::With.Value.One<Int32>(end)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> origin,
		Property::Any<Int32> start,
		Property::Any<Int32> end
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
		Property::Any<Int32> start,
		Property::Any<Int32> end
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