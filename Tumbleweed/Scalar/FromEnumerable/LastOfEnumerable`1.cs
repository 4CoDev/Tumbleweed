namespace Tumbleweed.Scalar.FromEnumerable;

public sealed class LastOfEnumerable<T> : IScalar<T>
{
	public LastOfEnumerable(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}

	public T Value => enumerable.Last();

	private readonly IEnumerable<T> enumerable;
}