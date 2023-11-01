using Property = Tumbleweed.Property;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Procedure = Tumbleweed.Subroutine.Procedure.Unary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Transput.With;

public sealed class Members<T> : Property::Transput.Any<T>
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
		new Property::Output.Function.Result.Actual<T>(accessor),
		mutator
	)
	{
	}
	
	public Members
	(
		Property::Output.Any<T> accessor,
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
	
	private readonly Property::Output.Any<T> accessor;
	
	private readonly Procedure::Any<T> mutator;
}