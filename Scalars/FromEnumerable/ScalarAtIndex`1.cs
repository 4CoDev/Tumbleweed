namespace Tumbleweed.Scalars.FromEnumerable;

public sealed class ScalarAtIndex<T> : IScalar<T>
{
	public ScalarAtIndex(IEnumerable<T> enumerable, IScalar<int> index)
	{
		this.enumerable = enumerable;
		this.index = index;
	}
	
	public T Value()
	{
		return enumerable.ElementAt(index.Value());
	}
	
	private readonly IEnumerable<T> enumerable;
	
	private readonly IScalar<int> index;
}