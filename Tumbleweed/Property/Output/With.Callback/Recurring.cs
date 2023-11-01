using Property = Tumbleweed.Property.Output;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Property.Output.With.Callback;

public sealed class Recurring<T> : Property::Envelope<T>
{
	public Recurring
	(
		T value,
		Procedure::Any callback
	) : this
	(
		new Property::With.Value<T>(value),
		callback
	)
	{
	}
	
	public Recurring
	(
		Property::Any<T> property,
		Procedure::Any callback
	) : base
	(
		new Property::Function.Result.Actual<T>(
			() => Function(property, callback))
	)
	{
	}
	
	private static T Function
	(
		Property::Any<T> property,
		Procedure::Any callback
	)
	{
		callback.Invoke();
		return property.Value;
	}
}