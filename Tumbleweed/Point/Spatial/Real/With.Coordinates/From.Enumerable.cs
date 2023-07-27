using Tumbleweed.Number.Real;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Spatial.Real.With.Coordinates.From;

public sealed class Enumerable : Envelope<Any>
{
	public Enumerable(IEnumerable<Any> enumerable) : base
	(
		new From.Collection(
			new List<Any>(enumerable))
	)
	{
	}
}