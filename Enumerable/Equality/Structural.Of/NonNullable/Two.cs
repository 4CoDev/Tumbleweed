using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.Function.Result;
using Tumbleweed.Property.Output;

using System = System;
using Object = Tumbleweed.Object;
using Property = Tumbleweed.Property;
using SC = System.Collections;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Equality.Structural.Of.NonNullable;

public sealed class Two : Mathematics.Boolean.Envelope
{
	public Two
	(
		System::Object first,
		System::Object second
	) : this
	(
		new Object.Casted.Convertee.Object<SC::IEnumerable>(first),
		new Object.Casted.Convertee.Object<SC::IEnumerable>(second)
	)
	{
	}
	
	public Two
	(
		Any<SC::IEnumerable> first,
		Any<SC::IEnumerable> second
	) : base
	(
		new Actual(
			() => Function(first.Value, second.Value))
	)
	{
	}

	private static Any Function
	(
		SC::IEnumerable first,
		SC::IEnumerable second
	) =>
	(
		Function(
			first.Cast<System::Object>(),
			second.Cast<System::Object>())
	);
	
	private static Any Function
	(
		SCG::IEnumerable<System::Object> first,
		SCG::IEnumerable<System::Object> second
	) =>
	(
		new One(
			first.SequenceEqual(second))
	);
}