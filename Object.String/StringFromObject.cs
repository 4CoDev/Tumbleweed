using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Option;
using Tumbleweed.String;
using Tumbleweed.String.From.System.Option;

namespace Tumbleweed.Object.String;

public sealed class StringFromObject : Envelope<Any>
{
	public StringFromObject(System.Object @object) : this
	(
		new Property.Output.With.Value.One<System.Object>(@object)
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