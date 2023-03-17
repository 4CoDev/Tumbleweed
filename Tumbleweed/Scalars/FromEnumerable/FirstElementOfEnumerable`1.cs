namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class FirstElementOfEnumerable<T> : IScalar<T>
{
	public FirstElementOfEnumerable(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}

	public T Value => enumerable.First();

	private readonly IEnumerable<T> enumerable;
}