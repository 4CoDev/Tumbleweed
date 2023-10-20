using Tumbleweed.Mathematics.Number.Integer;
using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Tumbleweed;

namespace Tumbleweed.Collection.Requirement.Length;

public sealed class Tumbleweed<T> : Envelope<T>
{
	public Tumbleweed
	(
		ICollection<T> collection,
		Any size
	) : base
	(
		new System<T>(
			collection,
			new One(size))
	)
	{
	}
}