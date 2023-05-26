using System.Collections;
using Tumbleweed.Scalar;

namespace Tumbleweed._Enumerable;

public sealed class EnumerableOfScalar : IEnumerable
{
	public EnumerableOfScalar(IScalar<IEnumerable> scalar) =>
		this.scalar = scalar;
	
	public IEnumerator GetEnumerator() =>
		scalar.Value.GetEnumerator();

	public override Boolean Equals(Object? @object) =>
		scalar.Value.Equals(@object);

	public override Int32 GetHashCode() =>
		scalar.Value.GetHashCode();
	
	public override String? ToString() =>
		scalar.Value.ToString();

	private readonly IScalar<IEnumerable> scalar;
}