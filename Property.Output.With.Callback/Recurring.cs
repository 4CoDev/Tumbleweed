using Property = Tumbleweed.Property.Output;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Property.Output.With.Callback;

public sealed class Recurring<T> : Property::Any<T>
{
	public Recurring
	(
		T value,
		Procedure::Any callback
	) : this
	(
		new Property::With.Value.One<T>(value),
		callback
	)
	{
	}
	
	public Recurring
	(
		Property::Any<T> property,
		Procedure::Any callback
	)
	{
		this.property = property;
		this.callback = callback;
	}

	public T Value
	{
		get
		{
			callback.Invoke();
			return property.Value;
		}
	}


	private readonly Property::Any<T> property;
	
	private readonly Procedure::Any callback;
}