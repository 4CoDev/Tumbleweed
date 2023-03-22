using System.Collections;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables;

public sealed class EnumerableOfScalar : IEnumerable
{
	public EnumerableOfScalar(IScalar<IEnumerable> scalar) =>
		this.scalar = scalar;
	
	public IEnumerator GetEnumerator() =>
		scalar.Value.GetEnumerator();

	private readonly IScalar<IEnumerable> scalar;
}