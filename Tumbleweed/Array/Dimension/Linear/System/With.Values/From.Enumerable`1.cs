// ReSharper disable once CheckNamespace
namespace Tumbleweed.Array.Linear.System.With.Values.From;

public sealed class Enumerable<T> : Tumbleweed.Scalar.Any<T[]>
{
	public Enumerable(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}

	public T[] Value => enumerable.ToArray();

	private readonly IEnumerable<T> enumerable;
}