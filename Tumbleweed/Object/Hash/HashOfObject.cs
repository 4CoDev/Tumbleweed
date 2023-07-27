using Tumbleweed.Scalar;

namespace Tumbleweed.Object.Hash;

public sealed class HashOfObject : Envelope<Int32>
{
	public HashOfObject(System.Object @object) : base
	(
		new Scalar.Function.Result<Int32>(
			@object.GetHashCode)
	)
	{
	}
}