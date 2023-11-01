using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;
using Property = Tumbleweed.Property.Output;
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
		new Property::With.Value<System::Int32>(size),
		filler
	)
	{
	}
	
	public System
	(
		Property::Any<System::Int32> size,
		Function::Any<T> filler
	) : base
	(
		new Enumerable::Filled.By.Property.Value.With.Length.System<T>(
			size,
			new Property::Function.Result.Actual<T>(filler))
	)
	{
	}
}