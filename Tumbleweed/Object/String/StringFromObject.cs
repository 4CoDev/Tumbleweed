using Tumbleweed.String;
using Tumbleweed.String.From.System.Nullable;

namespace Tumbleweed.Object.String;

public sealed class StringFromObject : Nullable.Envelope<Any>
{
	public StringFromObject(System.Object @object) : this
	(
		new Tumbleweed.Scalar.Of.Value<System.Object>(@object)
	)
	{
	}
	
	public StringFromObject(Scalar.Any<System.Object> @object) : base
	(
		new One(
			new Scalar.Function.Result<System.String?>(
				() => @object.Value.ToString()))
	)
	{
	}
}