using Property = Tumbleweed.Property;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Transput.Function;

public sealed class Result<T> : Property::Transput.Envelope<T>
{
	public Result
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

	public Result
	(
		Function::Any<Property::Transput.Any<T>> function
	) : base
	(
		new Property::Transput.Property.Value.One<T>(
			new Property::Output.Function.Result.Actual
				<Property::Transput.Any<T>>
				(function))
	)
	{
	}
}