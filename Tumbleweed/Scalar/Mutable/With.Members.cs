using Mutable = Tumbleweed.Scalar.Mutable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Procedure = Tumbleweed.Subroutine.Procedure.Unary;
using Immutable = Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Mutable.With;

public sealed class Members<T> : Mutable::Any<T>
{
	public Members
	(
		System::Func<T> accessor,
		System::Action<T> mutator
	) : this
	(
		new Function::From.System<T>(accessor),
		new Procedure::From.System<T>(mutator)
	)
	{
	}

	public Members
	(
		Function::Any<T> accessor,
		Procedure::Any<T> mutator
	) : this
	(
		new Immutable::Function.Result.Actual<T>(accessor),
		mutator
	)
	{
	}
	
	public Members
	(
		Immutable::Any<T> accessor,
		Procedure::Any<T> mutator
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
	
	private readonly Immutable::Any<T> accessor;
	
	private readonly Procedure::Any<T> mutator;
}