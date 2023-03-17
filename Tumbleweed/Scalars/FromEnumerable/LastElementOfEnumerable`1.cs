namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class LastElementOfEnumerable<T> : IScalar<T>
{
	public LastElementOfEnumerable(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}

	public T Value => enumerable.Last();

	private readonly IEnumerable<T> enumerable;
}