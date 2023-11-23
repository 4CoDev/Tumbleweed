using Collection = Tumbleweed.Collection;
using Integer = Tumbleweed.Mathematics.Number.Integer;
using Requirement = Tumbleweed.Collection.Requirement;

namespace Tumbleweed.Collection.Requirement.Length;

public sealed class Tumbleweed<T> : Collection::Envelope<T>
{
	public Tumbleweed
	(
		ICollection<T> collection,
		Integer::Any size
	) : base
	(
		new Requirement::Length.System<T>(
			collection,
			new Integer::System.Medium.From.Tumbleweed.One(size))
	)
	{
	}
}