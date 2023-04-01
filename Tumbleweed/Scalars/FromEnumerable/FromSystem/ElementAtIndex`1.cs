namespace Tumbleweed.Scalars.FromEnumerable.FromSystem;

public sealed class ElementAtIndex<T> : IScalar<T>
{
	public ElementAtIndex(IEnumerable<T> enumerable, Int32 index) : this
	(
		enumerable, new ScalarValue<Int32>(index)
	)
	{
	}
	
	public ElementAtIndex(IEnumerable<T> enumerable, IScalar<Int32> index)
	{
		this.enumerable = enumerable;
		this.index = index;
	}

	public T Value => enumerable.ElementAt(index.Value);

	private readonly IEnumerable<T> enumerable;
	
	private readonly IScalar<Int32> index;
}