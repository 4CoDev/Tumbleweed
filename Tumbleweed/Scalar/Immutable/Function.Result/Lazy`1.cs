using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Scalar.Immutable.Function.Result;

public sealed class Lazy<T> : Immutable::Envelope<T>
{
	public Lazy(System::Func<T> function) : this
	(
		new Function::From.System<T>(function)
	)
	{
	}
	
	public Lazy(Function::Any<T> function) : base
	(
		new Immutable::Lazy<T>(
			new Immutable::Function.Result.Actual<T>(function))
	)
	{
	}
}