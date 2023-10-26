using Number = Tumbleweed.Mathematics.Number;
using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;

public sealed class Multiple : Envelope<Int32>
{
	public Multiple
	(
		params Number::Natural.Any[] numbers
	) : this
	(
		new Concatenated<Number::Natural.Any>(numbers)
	)
	{
	}

	public Multiple
	(
		IEnumerable<Number::Natural.Any> numbers
	) : base
	(
		new Selected<Number::Natural.Any, Int32>(
			numbers,
			Expression)
	)
	{
	}

	private static Int32 Expression
	(
		Number::Natural.Any number
	) =>
		new Number::Integer.System.Medium.From.Natural.Tumbleweed.One(number).Value;

}