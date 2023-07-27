using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Enumerable.Item.From.Middle.By.Indents;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		SCG::IEnumerable<T> enumerable,
		System::Int32 from,
		System::Int32 to
	) : this
	(
		enumerable,
		new Scalar::Of.Value<Int32>(from),
		new Scalar::Of.Value<Int32>(to)
	)
	{
	}
	
	public System
	(
		SCG::IEnumerable<T> enumerable,
		Scalar::Any<Int32> from,
		Scalar::Any<Int32> to
	) : base
	(
		new Enumerable::Function.Result<T>(
			() => enumerable
				.Skip(from.Value)
				.Take(to.Value - from.Value + 1))
	)
	{
	}
}