using Tumbleweed.Property;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Function.Result;

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