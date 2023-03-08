using Tumbleweed.Bits;
using Tumbleweed.Existence.Equality;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Existence;

public sealed class ExistenceOfScalar<T> : IExistence<T>
{
	public ExistenceOfScalar(IScalar<IExistence<T>> scalar) =>
		this.scalar = scalar;

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new CodeFromNullables(Value, Exists).Value;

	public override String ToString() =>
		new StringFromNullables(Value, Exists).Value;

	public T Value => scalar.Value.Value;

	public IBit Exists => scalar.Value.Exists;

	private readonly IScalar<IExistence<T>> scalar;
}