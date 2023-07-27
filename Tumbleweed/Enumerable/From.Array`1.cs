using Enumerable = Tumbleweed.Enumerable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.From;

public sealed class Array<T> : Enumerable::Envelope<T>
{
	public Array(params T[] array) : base
	(
		new Enumerable::Function.Result<T>(
			array.AsEnumerable)
	)
	{
	}
}