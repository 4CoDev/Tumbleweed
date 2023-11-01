using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Nullable;
using Tumbleweed.String;
using Tumbleweed.String.From.System.Nullable;

namespace Tumbleweed.Object.String;

public sealed class StringFromObject : Envelope<Any>
{
	public StringFromObject(System.Object @object) : this
	(
		new Property.Output.With.Value<System.Object>(@object)
	)
	{
	}
	
	public StringFromObject(Property.Output.Any<System.Object> @object) : base
	(
		new One(
			new Actual<System.String?>(
				() => @object.Value.ToString()))
	)
	{
	}
}