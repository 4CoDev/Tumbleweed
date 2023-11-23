using Tumbleweed.Mathematics.Number.Integer;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Enumerable.Requirement.Length;

public sealed class Tumbleweed<T> : Enumerable::Envelope<T>
{
	public Tumbleweed
	(
		IEnumerable<T> enumerable,
		Any length
	) : base
	(
		new Collection.Requirement.Length.Tumbleweed<T>(
			new List<T>(enumerable),
			length)
	)
	{
	}
}