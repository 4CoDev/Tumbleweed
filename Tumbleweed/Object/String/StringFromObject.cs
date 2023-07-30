using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Nullable;
using Tumbleweed.String;
using Tumbleweed.String.From.System.Nullable;

namespace Tumbleweed.Object.String;

public sealed class StringFromObject : Envelope<Any>
{
	public StringFromObject(System.Object @object) : this
	(
		new Scalar.Immutable.With.Value<System.Object>(@object)
	)
	{
	}
	
	public StringFromObject(Scalar.Immutable.Any<System.Object> @object) : base
	(
		new One(
			new Actual<System.String?>(
				() => @object.Value.ToString()))
	)
	{
	}
}