using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using System = System;

namespace Tumbleweed.Scalar.Immutable.From.Enumerable.At.Index;

public sealed class System<T> : Immutable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<T> enumerable,
		System::Int32 index
	) : this
	(
		enumerable,
		new Immutable::With.Value<System::Int32>(index)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> enumerable,
		Immutable::Any<System::Int32> index
	) : base
	(
		new Immutable::Function.Result.Actual<T>(
			() => enumerable.ElementAt(index.Value))
	)
	{
	}
}