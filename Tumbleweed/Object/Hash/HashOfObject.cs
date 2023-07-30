using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace Tumbleweed.Object.Hash;

public sealed class HashOfObject : Envelope<Int32>
{
	public HashOfObject(System.Object @object) : base
	(
		new Actual<Int32>(
			@object.GetHashCode)
	)
	{
	}
}