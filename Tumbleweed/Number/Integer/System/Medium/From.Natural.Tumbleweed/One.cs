using Tumbleweed.Boolean.Literal;
using Tumbleweed.Enumerable;
using TW = Tumbleweed;

namespace Tumbleweed.Number.Integer.System.Medium.From.Natural.Tumbleweed;

public sealed class One : global::Tumbleweed.Scalar.Immutable.Envelope<Int32>
{
	public One(Number.Natural.Any numbers) : base
	(
		new Medium.With.Bits.New(
			new Appended<Boolean.Any>(
				numbers.Bits,
				new False()))
	)
	{
	}

}