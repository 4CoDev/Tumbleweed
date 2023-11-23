
namespace Tumbleweed.Mathematics.Number.Real.From.Enumerable.At.Index;

public sealed class Tumbleweed : Envelope
{
	public Tumbleweed
	(
		IEnumerable<global::Tumbleweed.Mathematics.Number.Real.Any> enumerable,
		global::Tumbleweed.Mathematics.Number.Integer.Any index
	) : base
	(
		new Collection.At.Index.Tumbleweed(
			new List<global::Tumbleweed.Mathematics.Number.Real.Any>(enumerable),
			index)
	)
	{
	}
}