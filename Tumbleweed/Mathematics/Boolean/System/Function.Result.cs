using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using TW = Tumbleweed;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Boolean.System.Function;

public sealed class Result : Envelope<global::System.Boolean>
{
	public Result
	(
		Func<global::System.Boolean> function
	) : this
	(
		new NullaryFunction.From.System<global::System.Boolean>(function)
	)
	{
	}
	
	public Result
	(
		NullaryFunction.Any<global::System.Boolean> function
	) : base
	(
		new Actual<global::System.Boolean>(function)
	)
	{
	}
}