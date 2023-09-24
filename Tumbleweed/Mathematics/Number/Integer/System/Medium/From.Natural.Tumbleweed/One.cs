using Tumbleweed.Enumerable;
using Tumbleweed.Mathematics.Boolean.Literal;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;

public sealed class One : global::Tumbleweed.Scalar.Immutable.Envelope<Int32>
{
	public One(global::Tumbleweed.Mathematics.Number.Natural.Any numbers) : base
	(
		new global::Tumbleweed.Mathematics.Number.Integer.System.Medium.With.Bits.New(
			new Appended<Boolean.Any>(
				numbers.Bits,
				new False()))
	)
	{
	}

}