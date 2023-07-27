using Tumbleweed.Array;
using Tumbleweed.Number.Natural;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Nullable.From.Array.At;

public sealed class Index<T> : Nullable.Envelope<T>
{
	public Index
	(Tumbleweed.Array.Any<Nullable.Any<T>> array,
		IEnumerable<Any> indices
	) : base
	(
		new Nullable.Result.Of.Function<T>(
			() => array[indices].Value)
	)
	{
	}
}