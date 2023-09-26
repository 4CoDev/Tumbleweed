using Scalar = Tumbleweed.Scalar.Immutable;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using Action = Tumbleweed.Array.Dimension.Spatial.System.Filling.Specific.Action;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.Specific.Source.Filler.Scalar.Value;

public sealed class One<T> : Scalar::Envelope<T[,,]>
{
	public One
	(
		Scalar::Any<T[,,]> array,
		Scalar::Any<T> filler
	) : base
	(
		new Scalar::With.Callback.Recurring<T[,,]>(
			array,
			new Action::Filler.Scalar.Value.One<T>(array, filler))
	)
	{
	}
}