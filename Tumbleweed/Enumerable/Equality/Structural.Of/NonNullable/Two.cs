using Boolean = Tumbleweed.Boolean;
using System = System;
using Object = Tumbleweed.Object;
using Scalar = Tumbleweed.Scalar;
using SC = System.Collections;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Equality.Structural.Of.NonNullable;

public sealed class Two : Boolean::Envelope
{
	public Two
	(
		System::Object first,
		System::Object second
	) : this
	(
		new Object::Unpacked<SC::IEnumerable>(first),
		new Object::Unpacked<SC::IEnumerable>(second)
	)
	{
	}
	
	public Two
	(
		Scalar::Any<SC::IEnumerable> first,
		Scalar::Any<SC::IEnumerable> second
	) : base
	(
		new Boolean::Function.Result(
			() => Function(first.Value, second.Value))
	)
	{
	}

	private static Boolean::Any Function
	(
		SC::IEnumerable first,
		SC::IEnumerable second
	) =>
	(
		Function(
			first.Cast<System::Object>(),
			second.Cast<System::Object>())
	);
	
	private static Boolean::Any Function
	(
		SCG::IEnumerable<System::Object> first,
		SCG::IEnumerable<System::Object> second
	) =>
	(
		new Boolean::From.System.One(
			first.SequenceEqual(second))
	);
}