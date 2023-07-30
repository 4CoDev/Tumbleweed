using Tumbleweed.Enumerable;
using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.From.Tumbleweed;

public sealed class One : global::Tumbleweed.Scalar.Immutable.Envelope<Int32>
{
	public One(Integer.Any integer) : base
	(
		new Medium.With.Bits.New(
			new Appended<Boolean.Any>(
				integer.Natural.Bits,
				integer.IsPositive))
	)
	{
	}

}