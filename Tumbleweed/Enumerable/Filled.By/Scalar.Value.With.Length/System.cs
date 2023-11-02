using Enumerable = Tumbleweed.Enumerable;
using System = System;
using Property = Tumbleweed.Property.Output;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Filled.By.Property.Value.With.Length;

public sealed class System<T> : Enumerable::Envelope<T>
{
	public System
	(
		System::Int32 length,
		Property::Any<T> filler
	) : this
	(
		new Property::With.Value.One<System::Int32>(length),
		filler
	)
	{
	}
	
	public System
	(
		Property::Any<System::Int32> length,
		Property::Any<T> filler
	) : base
	(
		new Enumerable::Function.Result<T>(
    () => Function(length, filler))
	)
	{
	}

	private static SCG::IEnumerable<T> Function
	(
		Property::Any<System::Int32> length,
		Property::Any<T> filler
	) =>
	(
		Function(length.Value, filler)
	);
	
	private static SCG::IEnumerable<T> Function
	(
		System::Int32 length,
		Property::Any<T> filler
	)
	{
		for (Int32 i = 0; i < length; i++)
			yield return filler.Value;
	}
}