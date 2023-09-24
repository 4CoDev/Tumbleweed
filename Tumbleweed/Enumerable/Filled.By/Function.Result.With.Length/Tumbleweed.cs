using Tumbleweed.Mathematics.Number.Natural;
using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Scalar = Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Enumerable.Filled.By.Function.Result.With.Length;

public sealed class Tumbleweed<T> : Enumerable::Envelope<T>
{
	public Tumbleweed
	(
		Any length,
		System::Func<T> filler
	) : this
	(
		length,
		new Function::From.System<T>(filler)
	)
	{
	}
	
	public Tumbleweed
	(
		Any length,
		Function::Any<T> filler
	) : base
	(
		new Enumerable::Filled.By.Scalar.Value.With.Length.Tumbleweed<T>(
			length,
			new Scalar::Function.Result.Actual<T>(filler))
	)
	{
	}
}