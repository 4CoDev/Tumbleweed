using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Literal;
using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.As;
using Tumbleweed.Scalar.Nullable.From.System;
using Boolean = Tumbleweed.Boolean;
using System = System;
using SC = System.Collections;

namespace Tumbleweed.Enumerable.Equality.Structural.Of.Nullable;

public sealed class Two : Mathematics.Boolean.Envelope
{
	public Two
	(
		System::Object? first,
		System::Object? second
	) : this
	(
		new One<System::Object>(first),
		new One<System::Object>(second)
	)
	{
	}
	
	public Two
	(
		Any<System::Object> first,
		Any<System::Object> second
	) : this
	(
		new Type<SC::IEnumerable>(first),
		new Type<SC::IEnumerable>(second)
	)
	{
	}
	
	public Two
	(
		SC::IEnumerable? first,
		SC::IEnumerable? second
	) : this
	(
		new One<SC::IEnumerable>(first),
		new One<SC::IEnumerable>(second)
	)
	{
	}
	
	public Two
	(
		Any<SC::IEnumerable> first,
		Any<SC::IEnumerable> second
	) : base
	(
		new Boolean::Function.Result(
			() => Function(first, second))
	)
	{
	}

	private static Any Function
	(
		Any<SC::IEnumerable> first,
		Any<SC::IEnumerable> second
	)
	{
		if (ReferenceEquals(first, second))
			return new True();
		if (first.HasValue.State && second.HasValue.State)
			return new NonNullable.Two(first.Value, second.Value);
		return new False();
	}
}