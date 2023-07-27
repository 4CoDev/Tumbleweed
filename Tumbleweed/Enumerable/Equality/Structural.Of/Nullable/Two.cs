using Boolean = Tumbleweed.Boolean;
using System = System;
using Nullable = Tumbleweed.Nullable;
using SC = System.Collections;

namespace Tumbleweed.Enumerable.Equality.Structural.Of.Nullable;

public sealed class Two : Boolean::Envelope
{
	public Two
	(
		System::Object? first,
		System::Object? second
	) : this
	(
		new Nullable::From.System.One<System::Object>(first),
		new Nullable::From.System.One<System::Object>(second)
	)
	{
	}
	
	public Two
	(
		Nullable::Any<System::Object> first,
		Nullable::Any<System::Object> second
	) : this
	(
		new Nullable::As.Type<SC::IEnumerable>(first),
		new Nullable::As.Type<SC::IEnumerable>(second)
	)
	{
	}
	
	public Two
	(
		SC::IEnumerable? first,
		SC::IEnumerable? second
	) : this
	(
		new Nullable::From.System.One<SC::IEnumerable>(first),
		new Nullable::From.System.One<SC::IEnumerable>(second)
	)
	{
	}
	
	public Two
	(
		Nullable::Any<SC::IEnumerable> first,
		Nullable::Any<SC::IEnumerable> second
	) : base
	(
		new Boolean::Function.Result(
			() => Function(first, second))
	)
	{
	}

	private static Boolean::Any Function
	(
		Nullable::Any<SC::IEnumerable> first,
		Nullable::Any<SC::IEnumerable> second
	)
	{
		if (ReferenceEquals(first, second))
			return new Boolean::Literal.True();
		if (first.HasValue.State && second.HasValue.State)
			return new NonNullable.Two(first.Value, second.Value);
		return new Boolean::Literal.False();
	}
}