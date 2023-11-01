using Property = Tumbleweed.Property.Output;
using Action = Tumbleweed.Array.Dimension.Spatial.System.Filling.Specific.Action;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.Specific.Source.Filler.Value;

public sealed class One<T> : Property::Envelope<T[,,]>
{
	public One
	(
		Property::Any<T[,,]> array,
		T filler
	) : base
	(
		new Property::With.Callback.Recurring<T[,,]>(
			array,
			new Action::Filler.Value.One<T>(array, filler))
	)
	{
	}
}