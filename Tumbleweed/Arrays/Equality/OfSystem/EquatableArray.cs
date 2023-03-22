using Tumbleweed.Enumerables.Equality;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Arrays.Equality.OfSystem;

public sealed class EquatableArray : IScalar<Array>
{
	public EquatableArray(Array array) : this
	(
		new ScalarOfValue<Array>(array)
	)
	{
	}
	
	public EquatableArray(IScalar<Array> array) =>
		this.array = array;

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(this, @object).State;

	public override Int32 GetHashCode() =>
		new CodeOfObject(Value).Value;

	public override String? ToString() =>
		new NullableFromObject(Value).Value;

	public Array Value => array.Value;
	
	private readonly IScalar<Array> array;
}