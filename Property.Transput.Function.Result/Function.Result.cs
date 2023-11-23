using Property = Tumbleweed.Property;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Property.Transput.Function.Result;

public sealed class One<T> : Property::Transput.Any<T>
{
	public One
	(
		System::Func<Property::Transput.Any<T>> function
	) : this
	(
		new Function::From.System
			<Property::Transput.Any<T>>
			(function)
	)
	{
	}

	public One
	(
		Function::Any<Property::Transput.Any<T>> function
	)
	{
		this.function = function;
	}
	
	public T Value
	{
		get => function.Result.Value;
		set => function.Result.Value = value;
	}

	private readonly Function::Any<Property::Transput.Any<T>> function;
}