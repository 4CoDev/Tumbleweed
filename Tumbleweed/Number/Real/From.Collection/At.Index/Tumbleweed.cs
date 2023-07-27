using Tumbleweed.Number.Integer.System.Medium.From.Tumbleweed;

namespace Tumbleweed.Number.Real.From.Collection.At.Index;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed
	(
		ICollection<Any> decimals,
		Integer.Any index
	) : base
	(
		new System(
			decimals,
			new One(index))
	)
	{
	}
}