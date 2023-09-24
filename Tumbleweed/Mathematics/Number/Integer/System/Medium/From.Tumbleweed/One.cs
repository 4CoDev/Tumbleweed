using Tumbleweed.Enumerable;

namespace Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Tumbleweed;

public sealed class One : global::Tumbleweed.Scalar.Immutable.Envelope<Int32>
{
	public One(global::Tumbleweed.Mathematics.Number.Integer.Any integer) : base
	(
		new global::Tumbleweed.Mathematics.Number.Integer.System.Medium.With.Bits.New(
			new Appended<Boolean.Any>(
				integer.Natural.Bits,
				integer.IsPositive))
	)
	{
	}

}