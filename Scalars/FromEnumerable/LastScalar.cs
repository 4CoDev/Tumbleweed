namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class LastScalar<T> : IScalar<T>
{
	public LastScalar(IEnumerable<T> enumerable)
	{
		this.enumerable = enumerable;
	}
	
	public T Value()
	{
		return enumerable.Last();
	}
	
	private readonly IEnumerable<T> enumerable;
}