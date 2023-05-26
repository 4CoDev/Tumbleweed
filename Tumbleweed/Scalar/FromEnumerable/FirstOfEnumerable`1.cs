namespace Tumbleweed.Scalar.FromEnumerable;

public sealed class FirstOfEnumerable<T> : IScalar<T>
{
	public FirstOfEnumerable(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}

	public T Value => enumerable.First();

	private readonly IEnumerable<T> enumerable;
}