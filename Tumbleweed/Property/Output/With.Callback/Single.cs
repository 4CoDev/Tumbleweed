using Property = Tumbleweed.Property.Output;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Property.Output.With.Callback;

public sealed class Single<T> : Property::Envelope<T>
{
	public Single
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
	
	public Single
	(
		Property::Any<T> property,
		Procedure::Any callback
	) : base
	(
		new Property::Lazy<T>(
			new Property::With.Callback.Recurring<T>(property, callback))
	)
	{
	}
}