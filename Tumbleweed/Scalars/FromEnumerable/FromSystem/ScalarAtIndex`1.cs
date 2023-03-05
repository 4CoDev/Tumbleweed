namespace Tumbleweed.Scalars.FromEnumerable.FromSystem;

public sealed class ScalarAtIndex<T> : IScalar<T>
{
	public ScalarAtIndex(IEnumerable<T> enumerable, Int32 index) : this
	(
		enumerable, new ScalarOfValue<Int32>(index)
	)
	{
	}
	
	public ScalarAtIndex(IEnumerable<T> enumerable, IScalar<Int32> index)
	{
		this.enumerable = enumerable;
		this.index = index;
	}

	public T Value => enumerable.ElementAt(index.Value);

	private readonly IEnumerable<T> enumerable;
	
	private readonly IScalar<Int32> index;
}