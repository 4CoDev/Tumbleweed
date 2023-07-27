
namespace Tumbleweed.Number.Real.From.Enumerable.At.Index;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed
	(
		IEnumerable<Real.Any> enumerable,
		Integer.Any index
	) : base
	(
		new Collection.At.Index.Tumbleweed(
			new List<Real.Any>(enumerable),
			index)
	)
	{
	}
}