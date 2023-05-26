using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable.Scalar;

public sealed class ReversedEnumerable<T> : IScalar<IEnumerable<T>>
{
	public ReversedEnumerable(IEnumerable<T> origin)
	{
		this.origin = origin;
	}

	public IEnumerable<T> Value => origin.Reverse();

	private readonly IEnumerable<T> origin;
}