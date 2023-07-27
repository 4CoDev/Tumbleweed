using Tumbleweed.Scalar.Function;
using NullaryFunction = Tumbleweed.Subroutine.Function.Nullary;
using UnaryProcedure = Tumbleweed.Subroutine.Procedure.Unary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Mutable.With;

public sealed class Members<T> : Mutable.Any<T>
{
	public Members
	(
		Func<T> accessor,
		Action<T> mutator
	) : this
	(
		new NullaryFunction.From.System<T>(accessor),
		new UnaryProcedure.From.System<T>(mutator)
	)
	{
	}

	public Members
	(
		NullaryFunction.Any<T> accessor,
		UnaryProcedure.Any<T> mutator
	) : this
	(
		new Scalar.Function.Result<T>(accessor),
		mutator
	)
	{
	}
	
	public Members
	(
		Scalar.Any<T> accessor,
		UnaryProcedure.Any<T> mutator
	)
	{
		this.accessor = accessor;
		this.mutator = mutator;
	}

	public T Value
	{
		get => accessor.Value;
		set => mutator.InvokeWith(value);
	}
	
	private readonly Scalar.Any<T> accessor;
	
	private readonly UnaryProcedure.Any<T> mutator;
}