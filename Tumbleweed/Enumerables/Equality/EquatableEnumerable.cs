using System.Collections;
using Tumbleweed.Objects.Hashes;
using Tumbleweed.Objects.Strings;

namespace Tumbleweed.Enumerables.Equality;

public sealed class EquatableEnumerable : IEnumerable
{
	public EquatableEnumerable(IEnumerable enumerable) =>
		this.enumerable = enumerable;

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new HashFromObjects(enumerable).Value;

	public override String ToString() =>
		new StringFromObjects(enumerable).Value;

	public IEnumerator GetEnumerator() =>
		enumerable.GetEnumerator();

	private readonly IEnumerable enumerable;
}