using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Scalar = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Filled.By.Scalar.Value.With.Length;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		System::Int32 length,
		Scalar::Any<T> filler
	) : this
	(
		new Scalar::With.Value<System::Int32>(length),
		filler
	)
	{
	}
	
	public System
	(
		Scalar::Any<System::Int32> length,
		Scalar::Any<T> filler
	) : base
	(
		new Enumerable::Function.Result<T>(
    () => Function(length, filler))
	)
	{
	}

	private static SCG::IEnumerable<T> Function
	(
		Scalar::Any<System::Int32> length,
		Scalar::Any<T> filler
	) =>
	(
		Function(length.Value, filler)
	);
	
	private static SCG::IEnumerable<T> Function
	(
		System::Int32 length,
		Scalar::Any<T> filler
	)
	{
		for (Int32 i = 0; i < length; i++)
			yield return filler.Value;
	}
}