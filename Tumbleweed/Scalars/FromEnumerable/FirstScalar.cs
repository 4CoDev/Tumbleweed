namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class FirstScalar<T> : IScalar<T>
{
	public FirstScalar(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}

	public T Value => enumerable.First();

	private readonly IEnumerable<T> enumerable;
}