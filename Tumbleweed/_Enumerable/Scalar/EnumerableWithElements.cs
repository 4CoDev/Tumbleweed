using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.Scalar;

public sealed class EnumerableWithElements<T> : IScalar<IEnumerable<T>>
{
	public EnumerableWithElements(IEnumerable<IEnumerable<T>> enumerables)
	{
		this.enumerables = enumerables;
	}

	public IEnumerable<T> Value
	{
		get { return enumerables.SelectMany(enumerable => enumerable); }
	}

	private readonly IEnumerable<IEnumerable<T>> enumerables;
}