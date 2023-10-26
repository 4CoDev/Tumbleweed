using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Boolean.Literal;
using Scalar = Tumbleweed.Scalar;
using Number = Tumbleweed.Mathematics.Number;
using Enumerable = Tumbleweed.Enumerable;
using Boolean = Tumbleweed.Mathematics.Boolean;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;

public sealed class One : Scalar::Immutable.Envelope<Int32>
{
	public One
	(
		Number::Natural.Any number
	) : base
	(
		new Number::Integer.System.Medium.With.Bits.New(
			new Enumerable::Appended<Boolean::Any>(
				number.Bits,
				new Boolean::Literal.False()))
	)
	{
	}

}