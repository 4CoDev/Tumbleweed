using System = System;
using Property = Tumbleweed.Property.Output;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Array.Dimension.Multi.Function.Result;

public sealed class Actual<T> : Envelope<T>
{
	public Actual
	(
		System::Func<Any<T>> function
	) : this
	(
		new Function::From.System<Any<T>>(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<Any<T>> function
	) : base
	(
		new Property.Value.Actual<T>(
			new Property::Function.Result.Actual
				<Any<T>>
				(function))
	)
	{
	}
}