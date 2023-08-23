using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Scalar = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Filled.By.Function.Result.With.Length;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		System::Int32 size,
		Function::Any<T> filler
	) : this
	(
		new Scalar::With.Value<System::Int32>(size),
		filler
	)
	{
	}
	
	public System
	(
		Scalar::Any<System::Int32> size,
		Function::Any<T> filler
	) : base
	(
		new Enumerable::Filled.By.Scalar.Value.With.Length.System<T>(
			size,
			new Scalar::Function.Result.Actual<T>(filler))
	)
	{
	}
}