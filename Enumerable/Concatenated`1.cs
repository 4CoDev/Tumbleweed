using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Enumerable;

public sealed class Concatenated<T> : Enumerable::Envelope<T>
{
	public Concatenated
	(
		params IEnumerable<T>[] enumerables
	) : this
	(
		new Enumerable::Function.Result<IEnumerable<T>>(
			enumerables.AsEnumerable)
	)
	{
	}
	
	public Concatenated
	(
		IEnumerable<IEnumerable<T>> enumerables
	) : base
	(
		new Enumerable::Function.Result<T>(
			() => enumerables.SelectMany(enumerable => enumerable))
	)
	{
	}
}