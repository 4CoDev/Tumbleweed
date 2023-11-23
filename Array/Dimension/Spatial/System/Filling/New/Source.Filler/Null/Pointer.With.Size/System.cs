using Property = Tumbleweed.Property.Output;
using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using System = System;

namespace Tumbleweed.Array.Dimension.Spatial.System.Filling.New.Source.Filler.Null.Pointer.With.Size;

public sealed class System<T> : Property::Envelope<T[,,]>
{
	public System
	(
		Vector::Generic.Any<System::Int32> size
	) : base
	(
		new Property::Function.Result.Actual<T[,,]>(
    () => new T[size.X, size.Y, size.Z])
	)
	{
	}
}