using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Tumbleweed;

namespace Tumbleweed.Mathematics.Number.Real.From.Collection.At.Index;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed
	(
		ICollection<Any> decimals,
		global::Tumbleweed.Mathematics.Number.Integer.Any index
	) : base
	(
		new System(
			decimals,
			new One(index))
	)
	{
	}
}