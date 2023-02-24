using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Scalar;

public sealed class ReversedEnumerable<T> : IScalar<IEnumerable<T>>
{
	public ReversedEnumerable(IEnumerable<T> origin)
	{
		this.origin = origin;
	}

	public IEnumerable<T> Value => origin.Reverse();

	private readonly IEnumerable<T> origin;
}