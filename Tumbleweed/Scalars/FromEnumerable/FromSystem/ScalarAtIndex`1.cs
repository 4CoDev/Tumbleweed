namespace Tumbleweed.Scalars.FromEnumerable.FromSystem;

public sealed class ScalarAtIndex<T> : IScalar<T>
{
	public ScalarAtIndex(IEnumerable<T> enumerable, int index) : this
	(
		enumerable, new ScalarOfValue<int>(index)
	)
	{
	}
	
	public ScalarAtIndex(IEnumerable<T> enumerable, IScalar<int> index)
	{
		this.enumerable = enumerable;
		this.index = index;
	}

	public T Value => enumerable.ElementAt(index.Value);

	private readonly IEnumerable<T> enumerable;
	
	private readonly IScalar<int> index;
}