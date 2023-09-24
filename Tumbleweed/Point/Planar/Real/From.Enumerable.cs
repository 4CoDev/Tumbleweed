using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Mathematics.Number.Real;
using Tumbleweed.Point.Planar.Real.From;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Point.Planar.Real.From;

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